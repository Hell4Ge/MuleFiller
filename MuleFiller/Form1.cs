using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using ProcessMemoryReaderLib;
using System.Threading.Tasks;
using System.Linq;

namespace MuleFiller
{
    public partial class Form1 : Form
    {
        private List<D2SharpMemory.ProcessReader> PR = new List<D2SharpMemory.ProcessReader>();
        private List<Process> Games = new List<Process>();
        private List<D2Human.D2H> D2HList = new List<D2Human.D2H>();

        // Game creation vars
        private int gameIndex = 0;
        private String diff = "";
        private String gamename = "";
        private bool usePassword = false;
        private String password = "";
        Task watcher = null;
        Task commanderUpdate = null;

        public Form1()
        {
            InitializeComponent();
            commanderUpdate = CommanderUpdate();
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(TB_SessionCount.Text, out n);

            if (TB_Prefix.Text.Equals("") || TB_Gamename.Text.Equals("") || TB_SessionCount.Equals("") || !isNumeric)
            {
                MessageBox.Show("You have incorrect values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Incorrect fields detected");
                return;
            }

            if (RB_Normal.Checked)
                diff = "Normal";

            if (RB_Nightmare.Checked)
                diff = "Nightmare";

            if (RB_Hell.Checked)
                diff = "Hell";

            if (!TB_Password.Text.Equals(""))
                usePassword = true;

            gamename = TB_Gamename.Text;



            // Fix mess caused with double click
            PR.Clear();
            D2HList.Clear();
            Games.Clear();

            int sessions = Convert.ToInt32(TB_SessionCount.Text);
            if (sessions <= 0)
            {
                MessageBox.Show("Error", "Session number have to be greater or equal 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Window prefix and suffix
            String prefix = TB_Prefix.Text;
            int suffix = 1;

            Process[] processlist = Process.GetProcesses(); // Load all existing processes
            
            // Pin existing sessions to the application
            foreach (Process p in processlist)
            {
                if (p.MainWindowTitle.Contains(prefix))
                {
                    Debug.WriteLine("Process has been added to game list, window name: " + p.MainWindowTitle);
                    Games.Add(p);
                }
            }

            sortListsOrder();   // sort games list to connect proper indexes with window names order

            for (int i=0; i<Games.Count; i++)
            {
                Debug.WriteLine(i.ToString() + ": Adding to PR: " + Games[i].MainWindowTitle);
                PR.Add(new D2SharpMemory.ProcessReader(Games[i]));
                Debug.WriteLine(i.ToString() + ": Adding to D2HList: " + Games[i].MainWindowTitle);
                D2HList.Add(new D2Human.D2H(Games[i].MainWindowTitle)); // Add to D2Human simulator class
            }

            // Fix number of sessions -> create nonexistent sessions
            int currentGames = Games.Count;
            MessageBox.Show(currentGames.ToString() + " " + Games.Count.ToString());
            if(currentGames < sessions)
            {
                suffix = currentGames + 1;
                
                for(int i=suffix;i<=sessions;i++)
                {
                    Debug.WriteLine("Starting game task: " + i.ToString());
                    var t = runGame(prefix + i.ToString());
                    t.Wait(250);
                    currentGames++;
                }
            }

            if (currentGames == sessions)
                LBL_GamesState.Text = "Games state: " + currentGames.ToString() + '/' + sessions.ToString();
        }

        private void BTN_Release_Click(object sender, EventArgs e)
        {
            watcher = CommandtWatcher();
            watcher.Wait(250);
            
            
        }


        private Task CommanderUpdate()
        {
            return Task.Run(() => {
                if (!watcher.Equals(null))
                {
                    LBL_Commander.Text = "Commander: " + watcher.Status.ToString();
                    Debug.WriteLine("Status: " + watcher.Status);
                }
                else
                {
                    LBL_Commander.Text = "Commander: null";
                }

                System.Threading.Thread.Sleep(250);
            });
        }

        private void sortListsOrder()
        {
            // Sort lists by window name to avoid problems with calling methods from enumerated lists
            Process temp = null;
            for (int i = 0; i < Games.Count; i++)
            {
                for (int sort = 0; sort < Games.Count - 1; sort++)
                {
                    string title1 = Games[sort].MainWindowTitle;
                    string title2 = Games[sort + 1].MainWindowTitle;

                    int titleAsIntSum1 = title1.Sum(b => b);    // This will work in this case
                    int titleAsIntSum2 = title2.Sum(b => b);

                    if (titleAsIntSum1 > titleAsIntSum2)
                    {
                        temp = Games[sort + 1];
                        Games[sort + 1] = Games[sort];
                        Games[sort] = temp;
                    }
                }
            }
        }


        //private Task runGame(String windowName, String acc, String pw, int ix)
        private Task runGame(String windowName)
        {
            return Task.Run(() =>
            {
                var r = D2Multi.D2Multi.Run(ucPathPicker.TB_Path.Text, true, true, windowName);
                System.Threading.Thread.Sleep(500);
                Games.Add(r);                                   // Add to process list
                PR.Add(new D2SharpMemory.ProcessReader(r));     // Add to memory reader handler
                D2HList.Add(new D2Human.D2H(windowName)); // Add to D2Human simulator class

                Debug.WriteLine("PR count: " + PR.Count);
                Debug.WriteLine("Games count: " + Games.Count);
                Debug.WriteLine("D2H count: " + D2HList.Count);
            });
        }

        private Task CommandtWatcher()
        {
            return Task.Run(() =>
            {
                D2SharpMemory.ProcessReader masterPR = PR[Games.Count - 1];
                D2Human.D2H masterDH = D2HList[Games.Count - 1];

                Debug.WriteLine("Game window: " + Games[Games.Count - 1].MainWindowTitle);
                Debug.WriteLine("Account: " + masterPR.getAccName());

                String lastChatMsg = "";
                String last = "";
                while (true)
                {
                    last = masterPR.getLastChatMsg();

                    if (!last.Equals(lastChatMsg))
                    {
                        Debug.WriteLine(last);
                        lastChatMsg = last;
                    }
                    
                    if (last.Equals("#cg") && masterPR.inGame())
                    {
                        for(int i=0; i<(D2HList.Count-1); i++)
                        {
                            D2HList[i].QuitGame();
                            System.Threading.Thread.Sleep(1500);

                            if (i == 0) // First window is game creator acc, it can't be a MASTER window
                            {
                                if(usePassword)
                                    D2HList[i].CreateGame(gamename + '-' + gameIndex, diff, password);
                                else
                                    D2HList[i].CreateGame(gamename + '-' + gameIndex, diff);
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(3000);
                                if(usePassword)
                                    D2HList[i].JoinGame(gamename + '-' + gameIndex, password);
                                else
                                    D2HList[i].JoinGame(gamename + '-' + gameIndex);
                            }
                        }
                        gameIndex++;
                    }

                    System.Threading.Thread.Sleep(100);
                }

            });
        }
        /*
        // Requires a lot of fixes to dont provoke join bugs
        private Task quitGame(D2Human.D2H Humanizer)
        {
            return Task.Run(() =>
            {
                Humanizer.QuitGame();
                System.Threading.Thread.Sleep(1500);
            });
        }

        private Task joinGame(D2Human.D2H Humanizer, String gameName, String pw="")
        {
            return Task.Run(() =>
            {
                Humanizer.JoinGame(gameName, pw);
                System.Threading.Thread.Sleep(2000);
            });
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This program was designed to work with patch 1.13c on private realms where D2 Multi is allowed\nI dont take any responsibility for banned accounts\nProceed?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                this.Dispose();
        }
    }
}

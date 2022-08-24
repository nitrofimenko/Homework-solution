using L04_13;
using System.Reflection.Metadata;

void WriteKeys(PlayerState state)
{
    ConsoleColor activeKeyColor = ConsoleColor.White;
    ConsoleColor inactiveKeyColor = ConsoleColor.DarkGray;
    ConsoleColor colorSTOP = activeKeyColor;
    ConsoleColor colorPLAY = activeKeyColor;
    ConsoleColor colorRECORD = activeKeyColor;
    ConsoleColor colorPAUSE = activeKeyColor;
    switch (state)
    {
        case PlayerState.STOP:
            colorSTOP = inactiveKeyColor;
            colorPAUSE = inactiveKeyColor;
            break;
        case PlayerState.PLAY:
            colorPLAY = inactiveKeyColor;
            colorRECORD = inactiveKeyColor;
            break;
        case PlayerState.RECORD:
            colorRECORD = inactiveKeyColor;
            colorPLAY = inactiveKeyColor;
            break;
        case PlayerState.PAUSE_PLAY:
            colorRECORD = inactiveKeyColor;
            break;
        case PlayerState.PAUSE_RECORD:
            colorPLAY = inactiveKeyColor;
            break;
        default:
            break;
    }
    ConsoleColor lastForegroundColor = Console.ForegroundColor;

    Console.ForegroundColor = colorSTOP;
    Console.Write(" ----------  ");
    Console.ForegroundColor = colorPLAY;
    Console.Write(" ----------  ");
    Console.ForegroundColor = colorRECORD;
    Console.Write(" ------------  ");
    Console.ForegroundColor = colorPAUSE;
    Console.Write(" -----------");
    Console.WriteLine();

    Console.ForegroundColor = colorSTOP;
    Console.Write("| 1 - STOP | ");
    Console.ForegroundColor = colorPLAY;
    Console.Write("| 2 - PLAY | ");
    Console.ForegroundColor = colorRECORD;
    Console.Write("| 3 - RECORD | ");
    Console.ForegroundColor = colorPAUSE;
    Console.Write("| 4 - PAUSE |");
    Console.WriteLine();

    Console.ForegroundColor = colorSTOP;
    Console.Write(" ----------  ");
    Console.ForegroundColor = colorPLAY;
    Console.Write(" ----------  ");
    Console.ForegroundColor = colorRECORD;
    Console.Write(" ------------  ");
    Console.ForegroundColor = colorPAUSE;
    Console.Write(" -----------");
    Console.WriteLine();

    Console.ForegroundColor = lastForegroundColor;
}

string GenerateMessage(PlayerState state, string choice)
{
    string[] actions = { "STOP", "PLAY", "RECORD", "PAUSE" };
    return "In " + Convert.ToString(state) + " state action " + actions[Convert.ToInt32(choice) - 1] + " is not available";
}

Player player = new Player();
IPlayable playerPlaying = player;
IRecodable playerRecording = player;
PlayerState state = PlayerState.STOP;
string choice;
string userAction = null;
string infoMessage = "";
const string WRONG_CHOICE = "Unknown command";
do
{
    if (infoMessage != "")
    {
        Console.WriteLine(infoMessage);
    }
    Console.WriteLine();
    Console.WriteLine($"Player state: {state}");
    if (userAction != null)
    {
        Console.WriteLine($"Last action: {userAction}");
    }
    Console.WriteLine();
    WriteKeys(state);
    Console.WriteLine("Caution: action PAUSE in PAUSE_PLAY or PAUSE_RECORD state");
    Console.WriteLine("switch to PLAY or RECORD state respectively.");
    Console.WriteLine();
    Console.WriteLine("0 - destroy");
    Console.Write("Your choice: ");
    choice = Console.ReadLine();
    Console.Clear();

    const ConsoleColor METHOD_COLOR = ConsoleColor.Magenta;
    ConsoleColor lastForegroundColor;
    if (choice != "0")
    {
        infoMessage = "";
        lastForegroundColor = Console.ForegroundColor;
        switch (state)
        {
            case PlayerState.STOP:
                switch (choice)
                {
                    case "1":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "2":
                        userAction = "PLAY";
                        Console.ForegroundColor = METHOD_COLOR;
                        player.Play();
                        Console.ForegroundColor = lastForegroundColor;
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    case "3":
                        userAction = "RECORD";
                        Console.ForegroundColor = METHOD_COLOR;
                        player.Record();
                        Console.ForegroundColor = lastForegroundColor;
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    case "4":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    default:
                        infoMessage = WRONG_CHOICE;
                        break;
                }
                break;
            case PlayerState.PLAY:
                switch (choice)
                {
                    case "1":
                        userAction = "STOP";
                        lastForegroundColor = Console.ForegroundColor;
                        Console.ForegroundColor = METHOD_COLOR;
                        playerPlaying.Stop();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerPlaying;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "3":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "4":
                        userAction = "PAUSE";
                        Console.ForegroundColor = METHOD_COLOR;
                        playerPlaying.Pause();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerPlaying;
                        state = PlayerState.PAUSE_PLAY;
                        break;
                    default:
                        infoMessage = WRONG_CHOICE;
                        break;
                }
                break;
            case PlayerState.RECORD:
                switch (choice)
                {
                    case "1":
                        userAction = "STOP";
                        Console.ForegroundColor = METHOD_COLOR;
                        playerRecording.Stop();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerRecording;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "3":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "4":
                        userAction = "PAUSE";
                        Console.ForegroundColor = METHOD_COLOR;
                        playerRecording.Pause();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerRecording;
                        state = PlayerState.PAUSE_RECORD;
                        break;
                    default:
                        infoMessage = WRONG_CHOICE;
                        break;
                }
                break;
            case PlayerState.PAUSE_PLAY:
                switch (choice)
                {
                    case "1":
                        userAction = "STOP";
                        Console.ForegroundColor = METHOD_COLOR;
                        playerPlaying.Stop();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerPlaying;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        userAction = "PLAY";
                        Console.ForegroundColor = METHOD_COLOR;
                        player.Play();
                        Console.ForegroundColor = lastForegroundColor;
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    case "3":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "4":
                        userAction = "PAUSE";
                        Console.ForegroundColor = METHOD_COLOR;
                        player.Play();
                        Console.ForegroundColor = lastForegroundColor;
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    default:
                        infoMessage = WRONG_CHOICE;
                        break;
                }
                break;
            case PlayerState.PAUSE_RECORD:
                switch (choice)
                {
                    case "1":
                        userAction = "STOP";
                        Console.ForegroundColor = METHOD_COLOR;
                        playerRecording.Stop();
                        Console.ForegroundColor = lastForegroundColor;
                        player = (Player)playerRecording;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        infoMessage = GenerateMessage(state, choice);
                        break;
                    case "3":
                        userAction = "RECORD";
                        Console.ForegroundColor = METHOD_COLOR;
                        player.Record();
                        Console.ForegroundColor = lastForegroundColor;
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    case "4":
                        userAction = "PAUSE";
                        Console.ForegroundColor= METHOD_COLOR;
                        player.Record();
                        Console.ForegroundColor = lastForegroundColor;
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    default:
                        infoMessage = WRONG_CHOICE;
                        break;
                }
                break;
            default:
                break;
        }
    }
}
while (choice != "0");
enum PlayerState
{
    STOP,
    PLAY,
    RECORD,
    PAUSE_PLAY,
    PAUSE_RECORD
}
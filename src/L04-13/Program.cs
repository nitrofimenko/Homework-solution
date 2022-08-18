using L04_13;

Player player = new Player();
IPlayable playerPlaying = player;
IRecodable playerRecording = player;
PlayerState state = PlayerState.STOP;
string choice;
do
{
    Console.WriteLine($"Player state: {state}");
    Console.WriteLine();
    Console.WriteLine("1 - STOP");
    Console.WriteLine("2 - PLAY");
    Console.WriteLine("3 - RECORD");
    Console.WriteLine("4 - PAUSE");
    Console.WriteLine("Caution: action PAUSE in PAUSE_PLAY or PAUSE_RECORD state");
    Console.WriteLine("switch to PLAY or RECORD state respectively.");
    Console.WriteLine("0 - destroy");
    Console.Write("Your choice: ");
    choice = Console.ReadLine();
    Console.WriteLine();
    if (choice != "0")
    {
        switch (state)
        {
            case PlayerState.STOP:
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"In {state} state action STOP is not available");
                        break;
                    case "2":
                        player.Play();
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    case "3":
                        player.Record();
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    case "4":
                        Console.WriteLine($"In {state} state action PAUSE is not available");
                        break;
                    default:
                        break;
                }
                break;
            case PlayerState.PLAY:
                switch (choice)
                {
                    case "1":
                        playerPlaying.Stop();
                        player = (Player)playerPlaying;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        Console.WriteLine($"In {state} state action PLAY is not available");
                        break;
                    case "3":
                        Console.WriteLine($"In {state} state action RECORD is not available");
                        break;
                    case "4":
                        playerPlaying.Pause();
                        player = (Player)playerPlaying;
                        state = PlayerState.PAUSE_PLAY;
                        break;
                    default:
                        break;
                }
                break;
            case PlayerState.RECORD:
                switch (choice)
                {
                    case "1":
                        playerRecording.Stop();
                        player = (Player)playerRecording;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        Console.WriteLine($"In {state} state action PLAY is not available");
                        break;
                    case "3":
                        Console.WriteLine($"In {state} state action RECORD is not available");
                        break;
                    case "4":
                        playerRecording.Pause();
                        player = (Player)playerRecording;
                        state = PlayerState.PAUSE_RECORD;
                        break;
                    default:
                        break;
                }
                break;
            case PlayerState.PAUSE_PLAY:
                switch (choice)
                {
                    case "1":
                        playerPlaying.Stop();
                        player = (Player)playerPlaying;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        player.Play();
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    case "3":
                        Console.WriteLine($"In {state} state action RECORD is not available");
                        break;
                    case "4":
                        player.Play();
                        playerPlaying = player;
                        state = PlayerState.PLAY;
                        break;
                    default:
                        break;
                }
                break;
            case PlayerState.PAUSE_RECORD:
                switch (choice)
                {
                    case "1":
                        playerRecording.Stop();
                        player = (Player)playerRecording;
                        state = PlayerState.STOP;
                        break;
                    case "2":
                        Console.WriteLine($"In {state} state action PLAY is not available");
                        break;
                    case "3":
                        player.Record();
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    case "4":
                        player.Record();
                        playerRecording = player;
                        state = PlayerState.RECORD;
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }
    Console.WriteLine();
} while (choice != "0");
enum PlayerState
{
    STOP,
    PLAY,
    RECORD,
    PAUSE_PLAY,
    PAUSE_RECORD
}
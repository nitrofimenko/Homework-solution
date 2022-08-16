using L03_11;

const string PRO_KEY = "Pro";
const string EXPERT_KEY = "Expert";

Console.WriteLine("Input access key or input nothing. Then strike Enter.");
Console.Write("Access key: ");
string accessKey = Console.ReadLine();

DocumentWorker worker;
switch (accessKey)
{
    case PRO_KEY:
        worker = new ProDocumentWorker();
        break;
    case EXPERT_KEY:
        worker = new ExpertDocumentWorker();
        break;
    default:
        worker = new DocumentWorker();
        break;
}
worker.OpenDocument();
worker.EditDocument();
worker.SaveDocument();
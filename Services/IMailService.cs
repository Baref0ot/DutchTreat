namespace DutchTreat.Serivces {
    public interface IMailService {
        string SendMessage(string to, string subject, string body);
    }// end interface
}

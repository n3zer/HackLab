using System.Collections.Generic;

namespace GrayHack.assets.scripts
{
    public class Quest
    {
        private int _id;
        private string _name;
        private string _description;
        private string _emailMsg;
        private bool _isCompleted;


        public static List<Quest> _quests = new List<Quest>
        {
            new Quest(1, "Кредитные данные", "Необходимо получить кредитные данные", "Cmming soon", false),
            new Quest(2, "Cmming soon", "Cmming soon", "Cmming soon", false)
        };

        public Quest(int id, string name, string description, string emailMsg, bool isCompleted)
        {
            _id = id;
            _name = name;
            _description = description;
            _emailMsg = emailMsg;
            _isCompleted = isCompleted;
        }
    }
}

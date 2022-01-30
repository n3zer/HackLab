
namespace GrayHack.assets.scripts
{
    class Quest
    {
        int _id;
        string _name;
        string _description;
        string _emailMsg;
        bool _isCompleted;

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

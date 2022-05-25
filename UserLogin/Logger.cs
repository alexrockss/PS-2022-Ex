using System.Text;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            UserContext userContext = new UserContext();

            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserRole + ";"
                + activity;

            currentSessionActivities.Add(activityLine);

            if (File.Exists("test.txt"))
            {
                File.WriteAllText("test.txt", activityLine);
            }

            userContext.Logs.Add(new Log { Message = activity });
        }

        public static IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();

            return currentSessionActivities;
        }

        public static IEnumerable<string> GetAllActivities()
        {
            return File.ReadAllLines("test.txt");
        }
    }
}

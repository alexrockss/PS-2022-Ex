using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserLogin
{
    static class Logger
    {
        private static List<string> currentSessionActiviies = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.CurrentUsername + ";" +
                                  LoginValidation.CurrentUserRole + ";" + activity;

            if (File.Exists("test.txt") == true)
            {
                File.AppendAllText("test.txt", activityLine);
            }

            currentSessionActiviies.Add(activityLine);
        }

        public static string GetCurrentSessionActivities()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var curr in currentSessionActiviies)
            {
                sb.Append(curr);
            }

            return sb.ToString();
        }
    }
}
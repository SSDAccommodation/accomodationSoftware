using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public class Log
    {
        public string logFileName = "log.txt";

        public Log()
        {

        }


        public void log(int custId, int action)
        {
            //string firstline = "username,user id,time/date,action\n";
            string logtext = custId + "," + DateTime.Now + ",";
            string actiontext = "";
            //action taken


            // 1 = Account created
            // 2 = Account updated
            // 3 = Account deleted
            // 4 = Aquired accommodation information
            // 5 = Aquired facility information
            // 6 = Booked an accommodation
            // 7 = Deleted a booking
            // 8 = Gave feedback about accommodation
            // 9 = Gave feedback about facility
            // 10 = Start of session
            // 11 = End of session



            string custAccCreatedText = "account created";
            string custAccEditedText = "account updated";
            string custAccdeletedText = "account deleted";
            string accInfoText = "aquired accommodation information";
            string facInfoText = "aquired facility information";
            string createBookingText = "booked an accommodation";
            string deleteBookingText = "deleted a booking";
            string accFeedbackText = "gave feedback about accommodation";
            string facFeedbackText = "gave feedback about facility";
            string logStart = "start of session";
            string logEnd = "end of session";

            switch (action)
            {
                case 1: actiontext = custAccCreatedText;
                    break;
                case 2: actiontext = custAccEditedText;
                    break;
                case 3: actiontext = custAccdeletedText;
                    break;
                case 4: actiontext = accInfoText;
                    break;
                case 5: actiontext = facInfoText;
                    break;
                case 6: actiontext = createBookingText;
                    break;
                case 7: actiontext = deleteBookingText;
                    break;
                case 8: actiontext = accFeedbackText;
                    break;
                case 9: actiontext = facFeedbackText;
                    break;
                case 10: actiontext = logStart;
                    break;
                case 11: actiontext = logEnd;
                    break;
                default:

                    break;


            }
            actiontext += "\n";
            logtext += actiontext;

            if (File.Exists(logFileName))
            {
                StreamWriter logFile = new StreamWriter(logFileName, true);
                logFile.WriteLine(logtext);
                if (action == 11) logFile.WriteLine();
                logFile.Close();
            }
            else
            {

                StreamWriter logFile2 = File.CreateText(Application.StartupPath + @"\log.txt");
                //logFile2.WriteLine(firstline);
                logFile2.WriteLine(logtext);
                if (action == 11) logFile2.WriteLine();
                logFile2.Close();
            }
        }


    }
}

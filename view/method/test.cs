using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace view
{
    public class test
    {
        public void DownloadAndUpdateAsync(string uri, string DownloadLocation)
        {
          
                WebClient web = new WebClient();
                //Assign the event handler
                web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                web.DownloadFileCompleted += new AsyncCompletedEventHandler(FileCompleted);
                //Download the file asynchronously
        
           
        }
        //event called for when download progress has changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //example code
            int i = 0;
            i++;
            Console.WriteLine(i);
        }
        //event called for when download has finished
        private void FileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Completed!");
        }
    }
}

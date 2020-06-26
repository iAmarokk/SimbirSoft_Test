﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SimbirSoft_Test
{
    public class HTMLWorker
    {
        public string[] site { get; private set; }
        public List<string> words = new List<string>();
        public HTMLWorker(string[] sites)
        {
            site = sites;
        }

        public void SaveHTMLPages()
        {
            for(int i = 0; i < site.Length; i++)
            {
                using (WebClient client = new WebClient())
                {
                    string directory = Directory.GetCurrentDirectory();
                    Console.WriteLine(site[i].ToString());
                    string html = client.DownloadString(site[i].ToString());
                    File.WriteAllText(directory + @"\" + i, html);
                    //Console.WriteLine(html);
                }
            }            
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class MediaManager
    {

        public MediaManager()
        {
            
        }
        public void printmedia(List<Movie> med)
        {
            int i = 1;
            foreach (Media media in med)
            {
                Console.WriteLine(i.ToString() + "." + media.Title);
                i++;
            }
        }
        public void printmedia(List<Series> med)
        {
            int i = 1;  
            foreach (Media media in med)
            {
               Console.WriteLine(i.ToString() + "." + media.Title);
                i++;
            }
        }

        public void GetDetails(IMedia med)
        {
            med.GetDetails();
        }

        public void Play(IWatch watch)
        {
            watch.Play();
        }
        public void Pause(IWatch watch)
        {
            watch.Pause();
        }
        public void Stop(IWatch watch)
        {
            watch.Stop();
        }
    }
}

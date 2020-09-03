using System;
using System.Collections.Generic;

namespace pa1_321
{
    public class Post
    {
        //getters n' setters
        public int Id{get; set;}

        public string Text{get; set;}

        public DateTime TimeStamp{get; set;} = DateTime.Now;

        public void IncId(int Id)
        {
            Id++;
        }
        public override string ToString()
        {
            return this.Id + "   " + this.Text + "     " + this.TimeStamp;
        }
// DateTime date1 = new DateTime(2020, 1, 1);
// TimeSpan ts = new TimeSpan(NextFile.LastWriteTime.Ticks - date1.Ticks);
// Console.WriteLine(Convert.ToInt32(ts.TotalSeconds));
//what is this
    }
}
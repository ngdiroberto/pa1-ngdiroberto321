using System;
using System.Collections.Generic;

namespace pa1_ngdiroberto321
{
    public class Post
    {
        public string ID{get; set;}
        public string PostText{get; set;}
        public string Date{get; set;}

        public string ToString(){
            return this.ID + " " + this.PostText + " " + this.Date + " ";
        }
    }
}
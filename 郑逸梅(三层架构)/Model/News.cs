using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class News
    {
       public News() { }
       private string _Title;
       private string _Content;
       private string _Author;
       private string _Subdate;
       private string _ID;
       private int _Hit;

       public string Title
       {
           set { _Title = value; }
           get { return _Title; }
       }
       public string Content
       {
           set { _Content = value; }
           get { return _Content; }
       }
       public string Author
       {
           set { _Author = value; }
           get { return _Author; }
       }
       public string Subdate
       {
           set { _Subdate = value; }
           get { return _Subdate; }
       }

       public string ID
       {
           set { _ID = value; }
           get { return _ID; }
       }
       public int Hit
       {
           set { _Hit = value; }
           get { return _Hit; }
       }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalStore
{
    public abstract class Media
    {
        public int id;
        public string description;
        public string thumbnailURL;
        public abstract bool Upload(string path);
    }

    public class Image : Media
    {
        public string originalURL;
        public string optimizedURL;
        public override bool Upload(string path)
        {
            return true;
        }
    }

    public class Video : Media
    {
        public string originalURL;
        public string standardURL;
        public string highURL;
        public string ultraURL;
        public string audioURL;
        public float duration;
        public override bool Upload(string path)
        {
            return true;
        }
    }
    
}

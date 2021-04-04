using System;
using System.Collections.Generic;
using ConsoleAppProject.App04;


namespace WebApps.Models
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Hamood Jaffery
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {

        // the name of the image file
        public String Filename { get; set; }

        // a one line image caption
        public String Caption { get; set; } 

    }
}

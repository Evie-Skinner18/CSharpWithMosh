using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    partial class Program

    // Events are mechanisms that allow communication between objects. our applications can be
    // more loosely coupled if we use them and like this they can be more extendable without brekaing
    {
        static void Main(string[] args)
        {
            // instantiate the video object. This one's Ariel aww!
            var ariel = new Video() {Title = "Ariel"};
            // instantiate the encoder object
            var videoEncoder = new VideoEncoder();
            // call Encode method on your new encoder, passing in the Ariel video as parameter
            videoEncoder.Encode(ariel);

     

         
            Console.ReadKey();

            // publisher /event sender; subscriber/ event receiver
            // an EVENT is a method that notifies the subscribers

            /*A DELEGATE is a contract between the publisher and the subscriber bitlike an
             *interface
             *
             */
        }
    }
}

using System.Diagnostics.CodeAnalysis;

namespace SeeSharp11Demo
{
    public class Literals
    {
        //required 
        public required string Longitude { get; set; }
        public required string Latitude { get; set; }

        [SetsRequiredMembers]
        public Literals()
        {
            Longitude = "50.937445";
            Latitude = "5.3459542";

            string longMessage = """
                This is a long message.
                It has several lines.
                    Some are indented
                            more than others.
                Some should start at the first column.
                Some have "quoted text" in them.
                """;

            //var location = $$"""
            //   You are at {{{Longitude}}, {{Latitude}}}
            //   """;

            Console.WriteLine(longMessage);
            //Console.WriteLine(location);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };
                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    
                };

                    context.Groups.Add(group);
                    context.Groups.Add(group2);
                    context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song(){ Name = "In the and", GroupId = group2.Id},
                    new Song(){ Name = "Numb", GroupId = group2.Id},
                    new Song(){ Name = "Mutter", GroupId = group.Id}

                };
                context.Songs.AddRange(songs);
                context.SaveChanges();


                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group.Name}");
                }
                
               // Console.WriteLine($"id: {group2.Id}, name: {group2.Name}, year: {group2.Year}");
                Console.ReadLine();
            }
        }
    }
}

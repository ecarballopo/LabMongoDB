using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    static class Program
    {
        public static MongoClient Cliente = new MongoClient();
        public static IMongoDatabase db = Cliente.GetDatabase("Laboratorio");
        public static IMongoCollection<Pelicula> Coll_Peliculas = db.GetCollection<Pelicula>("peliculas");
        public static IMongoCollection<Productora> Coll_Productoras = db.GetCollection<Productora>("productoras");
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string[] a = new string[2];
            a[0] = "1";
            a[1] = "2";
            Actores actores = new Actores(a);
            Pelicula nueva = new Pelicula("Titanic2","Drama","Director","Franquicia","USA","2006",120,"Productora",actores);
            ReadAllPelicula();
            CreateOnePelicula(nueva);
            ReadAllPelicula();
            UpdatePelicula("Titanic");
            ReadAllPelicula();
            DeletePelicula("Nuevo");
            ReadAllPelicula();
            
            var Peliculas = Coll_Peliculas.Find(b => b.NombreP == "Prueba").Limit(5).ToListAsync().Result;

            Console.WriteLine("Peliculas");
            foreach(var pelicula in Peliculas)
            {
                Console.WriteLine("*" + pelicula._id);
            }*/
            TituloPelicula("Titanic2");
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Programa());*/
        }


        public class Pelicula
        {
            public ObjectId _id { get; set; }
            public float IdPelicula { get; set; }
            public string NombreP { get; set; }
            public string GeneroP { get; set; }
            public string NombreD { get; set; }
            public string Franquicia { get; set; }
            public string Pais { get; set; }
            public string Año { get; set; }
            public float Duracion { get; set; }
            public string Productora { get; set; }
            public Actores Actores { get; set; }

            public Pelicula(string nombreP,string generoP,string nombreD,string franquicia,
                string pais,string año, float duracion,string productora,Actores actores)
            {
                NombreP = nombreP;
                GeneroP = generoP;
                NombreD = nombreD;
                Franquicia = franquicia;
                Pais = pais;
                Año = año;
                Duracion = duracion;
                Productora = productora;
                Actores = actores;
            }
        }

        public class Actores
        {
            public string[] NombreA { get; set; }

            public Actores(string[] nombreA)
            {
                NombreA = nombreA;
            }
        }


        public class Productora
        {
            public ObjectId _id { get; set; }
            public float IdProductora { get; set; }
            public string NombreCP { get; set; }
            public string Año { get; set; }
            public string Web { get; set; }

            public Productora(string nombreCP,string año, string web)
            {
                NombreCP = nombreCP;
                Año = año;
                Web = web;
            }
        }

        //Peliculas
        public static void CreateOnePelicula(Pelicula pelicula)
        {
            Coll_Peliculas.InsertOne(pelicula);
        }
        public static void ReadAllPelicula()
        {
            List<Pelicula> Peliculas = Coll_Peliculas.AsQueryable().ToList<Pelicula>();
            var peliculas = from p in Peliculas select p;

            Console.WriteLine("Peliculas");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula._id + " " + pelicula.NombreP + " " + pelicula.NombreD + " " + pelicula.Franquicia 
                    + " " + pelicula.Pais + " " + pelicula.Año + " " + pelicula.Duracion + " " 
                    + pelicula.Productora + " " + pelicula.Actores.NombreA[0]);
            }
        }

        public static void TituloPelicula(string titulo)
        {
            var peliculas = Coll_Peliculas.Find(b => b.NombreP == titulo).Limit(100).ToListAsync().Result;

            Console.WriteLine("Por Titulo");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula._id + " " + pelicula.NombreP + " " + pelicula.NombreD + " " + pelicula.Franquicia
                    + " " + pelicula.Pais + " " + pelicula.Año + " " + pelicula.Duracion + " "
                    + pelicula.Productora + " " + pelicula.Actores.NombreA[0]);
            }
        }

        public static void FranquiciaPelicula(string franquicia)
        {
            var peliculas = Coll_Peliculas.Find(b => b.Franquicia == franquicia).Limit(100).ToListAsync().Result;

            Console.WriteLine("Por Franquicia");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula._id + " " + pelicula.NombreP + " " + pelicula.NombreD + " " + pelicula.Franquicia
                    + " " + pelicula.Pais + " " + pelicula.Año + " " + pelicula.Duracion + " "
                    + pelicula.Productora + " " + pelicula.Actores.NombreA[0]);
            }
        }

        public static void AñoPelicula(float añoI,float añoF)
        {
            var peliculas = Coll_Peliculas.Find(b => System.Convert.ToSingle(b.Año) <= añoF).Limit(100).ToListAsync().Result;

            Console.WriteLine("Por Franquicia");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula._id + " " + pelicula.NombreP + " " + pelicula.NombreD + " " + pelicula.Franquicia
                    + " " + pelicula.Pais + " " + pelicula.Año + " " + pelicula.Duracion + " "
                    + pelicula.Productora + " " + pelicula.Actores.NombreA[0]);
            }
        }

        public static void ProductoraPelicula(string productora)
        {
            var peliculas = Coll_Peliculas.Find(b => b.Productora == productora).Limit(100).ToListAsync().Result;

            Console.WriteLine("Por Productora");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula.NombreP + " " + pelicula.GeneroP + " " + pelicula.Año);
            }
        }

        public static void UpdatePelicula(string nombreP)
        {
            var UpdateP = Builders<Pelicula>.Update.Set(s => s.NombreP,"Nuevo");
            Coll_Peliculas.UpdateOne(s => s.NombreP == nombreP, UpdateP);
        }
        public static void DeletePelicula(string nombreP)
        {
            Coll_Peliculas.DeleteOne(s => s.NombreP == nombreP);
        }

        //Productoras
        public static void CreateOneProductora(Productora productora)
        {
            Coll_Productoras.InsertOne(productora);
        }
        public static void ReadAllProductora()
        {
            List<Productora> Productoras = Coll_Productoras.AsQueryable().ToList<Productora>();
            var productoras = from p in Productoras select p;

            Console.WriteLine("Peliculas");
            foreach (var productora in productoras)
            {
                Console.WriteLine(productora._id + " " + productora.NombreCP + " " + productora.Año + " " + productora.Web);
            }
        }
        public static void UpdateProductora(string nombreCP)
        {
            var UpdateCP = Builders<Productora>.Update.Set(s => s.NombreCP, "Nuevo");
            Coll_Productoras.UpdateOne(s => s.NombreCP == nombreCP, UpdateCP);
        }
        public static void DeleteProductora(string nombreCP)
        {
            Coll_Productoras.DeleteOne(s => s.NombreCP == nombreCP);
        }

        public static void Estadisticas(string productora)
        {
            var peliculas = Coll_Peliculas.Find(b => b.Productora == productora).Count();

           
        }
    }
}

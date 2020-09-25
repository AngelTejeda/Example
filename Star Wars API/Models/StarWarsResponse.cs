using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Text;

namespace Star_Wars_API.Models {
    public class StarWarsResponse {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Result> Results { get; set; }
        public string MoreInfo { 
            get {
                return Count + " " + Next;
            }
            set {
                MoreInfo = value;
            }
        }

        public StarWarsResponse() {
            Results = new List<Result>();
        }

    }

    public class Result {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; }
        public List<string> Species { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Starships { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }

        public Result() {
            Films = new List<string>();
            Species = new List<string>();
            Vehicles = new List<string>();
            Starships = new List<string>();
        }
    }

    public class Homeworld {
        public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        public List<string> residents { get; set; }
        public List<string> films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }

        public Homeworld() {
            residents = new List<string>();
            films = new List<string>();
        }
    }
}

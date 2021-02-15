using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._14_GenerischeTypen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Bisher: Datenfelder
			// Nachteil: Größe muss bereits zu Beginn festgelegt werden
			string[] datenfeld = new string[5];
			datenfeld[0] = "Hallo";
			datenfeld[1] = "Welt";

			// Alternativ: Liste anlegen
			// - Datenstruktur Liste
			// - vom Datentyp string
			List<string> meineListe = new List<string>();
			List<int> meineZahlenListe = new List<int>();

			meineListe.Add("Hallo");
			meineListe.Add("Welt");
			meineListe.Add("Mittagessen");

			// Anzahl der Elemente ausgeben
			Console.WriteLine("Die Liste besitzt " + meineListe.Count + " Elemente");
			
			// Alle Elemente in die Konsole ausgeben
			Console.WriteLine("Die Elemente der Liste: ");
			foreach (var element in meineListe)
			{
				Console.WriteLine(element);
			}

			// Index eines Elements auslesen
			Console.WriteLine("Index des Elements Welt: " + meineListe.IndexOf("Welt"));

			// Prüfen, ob ein Element existiert
			Console.WriteLine("Existiert das Element Welt?");
			Console.WriteLine(meineListe.Contains("Welt"));
			Console.WriteLine("Existiert das Element Mittagessen?");
			Console.WriteLine(meineListe.Contains("Mittagessen"));

			// Liste sortiert ausgeben
			meineListe.Sort();
			Console.WriteLine("Die Elemente der Liste nach dem Sortieren: ");
			foreach (var element in meineListe)
			{
				Console.WriteLine(element);
			}

			// Element löschen (über den Inhalt)
			meineListe.Remove("Welt");
			Console.WriteLine("Die Elemente der Liste nach dem Löschen: ");
			foreach (var element in meineListe)
			{
				Console.WriteLine(element);
			}

			// Element löschen (über den Index)
			meineListe.RemoveAt(0);
			Console.WriteLine("Die Elemente der Liste nach dem Löschen: ");
			foreach (var element in meineListe)
			{
				Console.WriteLine(element);
			}
		}
	}
}

﻿namespace Busca_Lagura
{
	public class Vertice
	{		
		public string Cidade { get; set; }
		public bool Status { get; set; }
		public int Grau { get; set; }
		public Aresta Adjacentes { get; set; }
		public Vertice Proximo { get; set; }

	}
}

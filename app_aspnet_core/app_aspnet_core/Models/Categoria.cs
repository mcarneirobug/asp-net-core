using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_aspnet_core.Models
{
	// estamos sinalizando que vamos ter uma tabela no banco de dados 
	[Table("Categorias")] 
	public class Categoria
	{
		[Key] // PK e auto incremento 
		[Display(Name ="Código")] // maneira que vai aparecer na minha view
		public int Id { get; set; }

		[Display(Name="Descrição")]
		[Required(ErrorMessage ="Campo Obrigatório")]
		public string Descricao { get; set; }
	}
}

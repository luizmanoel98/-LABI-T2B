using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLuizManoel.Models
{
    public class Musica
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatorio!!!")] 
        [MaxLength(400 , ErrorMessage = "Máximo 400 caracteres!" )]
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        [Display(Name = "Tipo de Mídia")]
        public TipoMidia TipoMidia { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
 
    }
}
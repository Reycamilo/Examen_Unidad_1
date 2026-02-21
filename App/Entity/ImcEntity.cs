using System.ComponentModel.DataAnnotations;

public class ImcEntity
{
    [Required(ErrorMessage ="Debe ingresar un peso.")]
    public double peso { get; set; }


    [Required(ErrorMessage ="Debe ingresar una altura.")]
    public double altura { get; set; }
    public double imc { get; set; }
    public string clasificacion { get; set; }
}
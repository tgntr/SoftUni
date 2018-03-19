public interface ICar
{
    string Model { get; }

    string Driver { get; set; }

    string Brake();

    string Gas();
}
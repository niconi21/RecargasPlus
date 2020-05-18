package Objects;

public class Recarga {
    private int id;
    private String numero;
    public Colaborador colaborador;
    public Bonificacion bonificacion;
    public Compania compania;
    public Monto monto;
    public Recarga(){
        this.colaborador = new Colaborador();
        this.bonificacion = new Bonificacion();
        this.compania = new Compania();
        this.monto = new Monto();
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNumero() {
        return numero;
    }

    public void setNumero(String numero) {
        this.numero = numero;
    }
}

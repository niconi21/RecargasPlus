package Objects;

public class Bonificacion {
    private int id;
    private double bonificacion;
    public Compania compania;
    public Monto monto;

    public  Bonificacion(){
         this.compania = new Compania();
         this.monto = new Monto();
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getBonificacion() {
        return bonificacion;
    }

    public void setBonificacion(double bonificacion) {
        this.bonificacion = bonificacion;
    }


}

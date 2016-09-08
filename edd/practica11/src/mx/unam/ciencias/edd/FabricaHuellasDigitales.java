package mx.unam.ciencias.edd;

/**
 * Clase para fabricar generadores de huellas digitales.
 */
public class FabricaHuellasDigitales {

        private static class Bj implements HuellaDigital<String>{

                @Override public int huellaDigital(String cadena) {
                    int h = (int)hash(cadena);
                    return h;
                }

                /*Atributos*/
                private static final long MAX_VALUE = 0x00000000ffffffffL; 
                public long a;
                public long b;
                public long c;
                
                public int hash(String cadena) { 
                    byte[] buffer = cadena.getBytes();
                    int l = buffer.length;
                    int k = 0; //es pos
                    a = b = 0x000000009e3779b9L;
                    c = 0xffffffff;
                    while(l >= 12) {
                        a += (buffer[k] + (buffer[k+1] << 8) + (buffer[k+2] << 16) + (buffer[k+3] << 24));
                        b += (buffer[k+4] + (buffer[k+5] << 8) + (buffer[k+6] << 16) + (buffer[k+7] << 24));
                        c += (buffer[k+8] + (buffer[k+9] << 8) + (buffer[k+10] << 16) + (buffer[k+11] << 24));
                        mezcla();
                        k += 12;
                        l -= 12;
                    }
                    c += buffer.length;
                    switch(l) {
                        case 11 :
                            c = (c + ((byteToLong(buffer[k+10])<<24)& MAX_VALUE)) & MAX_VALUE;
                        case 10 :
                            c = (c + ((byteToLong(buffer[k+9])<<16)& MAX_VALUE)) & MAX_VALUE;
                        case 9 :
                            c = (c + ((byteToLong(buffer[k+8])<<8)& MAX_VALUE)) & MAX_VALUE;
                        case 8 :
                            b = (b + ((byteToLong(buffer[k+7])<<24)& MAX_VALUE)) & MAX_VALUE;
                        case 7 :
                            b = (b + ((byteToLong(buffer[k+6])<<16)& MAX_VALUE)) & MAX_VALUE;
                        case 6 :
                            b = (b + ((byteToLong(buffer[k+5])<<8)& MAX_VALUE)) & MAX_VALUE;
                        case 5 :
                            b = (b + byteToLong(buffer[k+4])) & MAX_VALUE;
                        case 4 :
                            a = (a + ((byteToLong(buffer[k+3])<<24)& MAX_VALUE)) & MAX_VALUE;
                        case 3 :
                            a = (a + ((byteToLong(buffer[k+2])<<16)& MAX_VALUE)) & MAX_VALUE;
                        case 2 :
                            a = (a + ((byteToLong(buffer[k+1])<<8)& MAX_VALUE)) & MAX_VALUE;
                        case 1 :
                            a = (a + byteToLong(buffer[k+0])) & MAX_VALUE;
                    }
                    mezcla();
                    //System.out.println("ALalalalalalal");
                    return (int)(c&0xffffffff);
                }

                private void mezcla(){
                    a = (a-b) & MAX_VALUE; a = (a-c) & MAX_VALUE; a = (a^(c>>13)) & MAX_VALUE;
                    b = (b-c) & MAX_VALUE; b = (b-a) & MAX_VALUE; b = (b^((a<<8)& MAX_VALUE)) & MAX_VALUE;
                    c = (c-a) & MAX_VALUE; c = (c-b) & MAX_VALUE; c = (c^(b>>13)) & MAX_VALUE;
                    a = (a-b) & MAX_VALUE; a = (a-c) & MAX_VALUE; a = (a^(c>>12)) & MAX_VALUE;
                    b = (b-c) & MAX_VALUE; b = (b-a) & MAX_VALUE; b = (b^((a<<16)& MAX_VALUE)) & MAX_VALUE;
                    c = (c-a) & MAX_VALUE; c = (c-b) & MAX_VALUE; c = (c^(b>>5)) & MAX_VALUE;
                    a = (a-b) & MAX_VALUE; a = (a-c) & MAX_VALUE; a = (a^(c>>3)) & MAX_VALUE;
                    b = (b-c) & MAX_VALUE; b = (b-a) & MAX_VALUE; b = (b^((a<<10)& MAX_VALUE)) & MAX_VALUE;
                    c = (c-a) & MAX_VALUE; c = (c-b) & MAX_VALUE; c = (c^(b>>15)) & MAX_VALUE;
                }
                private long byteToLong(byte b) {
                    long val = b & 0x7F;
                    return val;
                }
            }
    /**
     * Identificador para fabricar la huella digital de Bob
     * Jenkins para cadenas.
     */
    public static final int BJ_STRING   = 0;
    /**
     * Identificador para fabricar la huella digital de GLib para
     * cadenas.
     */
    public static final int GLIB_STRING = 1;
    /**
     * Identificador para fabricar la huella digital de XOR para
     * cadenas.
     */
    public static final int XOR_STRING  = 2;



    /**
     * Regresa una instancia de {@link HuellaDigital} para cadenas.
     * @param identificador el identificador del tipo de huella
     *        digital que se desea.
     * @throws IllegalArgumentException si recibe un identificador
     *         no reconocido.
     */
    public static HuellaDigital<String> getInstanciaString(int identificador) {
        // Aquí va su código.
        if(identificador > 2 || identificador < 0)
            throw new IllegalArgumentException();
        switch (identificador) {
            case 1 : //GLIB
            return new HuellaDigital<String>() {
                public int huellaDigital(String cadena) {
                    byte[] arreglo = cadena.getBytes();
                    int n = arreglo.length;
                    int h = 5381;
                    for(int i = 0; i < n; i++) {
                        char c = (char)arreglo[i];
                        h = h*33 + c;
                    }
                    //System.out.println("Lalalaal");     
                    return h;
                }
            };
            case 2 : //XOR
            return new HuellaDigital<String>() {
                public int huellaDigital(String cadena) {
                    byte[] k = cadena.getBytes();
                    int m = k.length;
                    int n = k.length;
                    if((n&3) != 0)
                        m = n + 4 - (n&3);
                    byte[] t = new byte[m];
                    for(int i = m-n; i < m; i++)
                        t[i] = k[i-(m-n)];
                    int h = 0;
                    for(int j = 0; j < m; j+=4) {
                        int a = (int)t[j] << 24;
                        int b = (int)t[j+1] << 16;
                        int c = (int)t[j+2] << 8;
                        int d = (int)t[j+3];
                        int abcd = a|b|c|d;
                        h ^= abcd;
                    }
                    return h;
                }
            };
            case 0 : //BJ
            return new Bj();
        }
        return null;
    }
}

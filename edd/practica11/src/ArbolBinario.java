package mx.unam.ciencias.edd;

import java.util.NoSuchElementException;

/**
 * <p>Clase abstracta para árboles binarios genéricos.</p>
 *
 * <p>La clase proporciona las operaciones básicas para árboles
 * binarios, pero deja la implementación de varios en manos de las
 * clases concretas.</p>
 */
public abstract class ArbolBinario<T> implements Iterable<T> {

    /**
     * Clase interna protegida para vértices.
     */
    protected class Vertice<T> implements VerticeArbolBinario<T> {
        /** El elemento del vértice. */
        public T elemento;
        /** El padre del vértice. */
        public Vertice<T> padre;
        /** El izquierdo del vértice. */
        public Vertice<T> izquierdo;
        /** El derecho del vértice. */
        public Vertice<T> derecho;
        /** El color del vértice. */
        public Color color;

        /**
         * Constructor único que recibe un elemento.
         * @param elemento el elemento del vértice.
         */
        public Vertice(T elemento) {
            this.elemento = elemento;
        }

        /**
         * Regresa una representación en cadena del vértice.
         * @return una representación en cadena del vértice.
         */
        public String toString() {
            //Aquí va su código.
            return elemento.toString();
        }

        /**
         * Nos dice si el vértice tiene un padre.
         * @return <tt>true</tt> si el vértice tiene padre,
         *         <tt>false</tt> en otro caso.
         */
        @Override public boolean hayPadre() {
            // Aquí va su código.
            return padre != null;
        }

        /**
         * Nos dice si el vértice tiene un izquierdo.
         * @return <tt>true</tt> si el vértice tiene izquierdo,
         *         <tt>false</tt> en otro caso.
         */
        @Override public boolean hayIzquierdo() {
            // Aquí va su código.
            return izquierdo != null;
        }

        /**
         * Nos dice si el vértice tiene un derecho.
         * @return <tt>true</tt> si el vértice tiene derecho,
         *         <tt>false</tt> en otro caso.
         */
        @Override public boolean hayDerecho() {
            // Aquí va su código.
            return derecho != null;
        }

        /**
         * Regresa el padre del vértice.
         * @return el padre del vértice.
         * @throws NoSuchElementException si el vértice no tiene padre.
         */
        @Override public VerticeArbolBinario<T> getPadre() {
            // Aquí va su código.
            return padre;
        }

        /**
         * Regresa el izquierdo del vértice.
         * @return el izquierdo del vértice.
         * @throws NoSuchElementException si el vértice no tiene izquierdo.
         */
        @Override public VerticeArbolBinario<T> getIzquierdo() {
            // Aquí va su código.
            return izquierdo;
        }

        /**
         * Regresa el derecho del vértice.
         * @return el derecho del vértice.
         * @throws NoSuchElementException si el vértice no tiene derecho.
         */
        @Override public VerticeArbolBinario<T> getDerecho() {
            // Aquí va su código.
            return derecho;
        }

        /**
         * Regresa el elemento al que apunta el vértice.
         * @return el elemento al que apunta el vértice.
         */
        @Override public T get() {
            // Aquí va su código.
            return elemento;
        }

        /**
        * Regresa el color del vértice.
        * @return el color del vértice.
        */
        @Override public Color getColor() {
            return color;
        }
    }

    /** La raíz del árbol. */
    protected Vertice<T> raiz;
    /** El número de elementos */
    protected int elementos;

    /**
     * Construye un árbol con cero elementos.
     */
    public ArbolBinario() {
        // Aquí va su código.
        raiz = null;
        elementos = 0;
    }

    /**
     * Regresa la profundidad del árbol. La profundidad de un árbol
     * es la longitud de la ruta más larga entre la raíz y una hoja.
     * @return la profundidad del árbol.
     */
    public int profundidad() {
        // Aquí va su código.  
        return auxProfundidad(raiz);
    }

    /**
     *
     *
     *
     */
    private int auxProfundidad(VerticeArbolBinario<T> v){
        int profizq = 0;
        int profder = 0;
        if(v == null)
            return -1;
        else{
            profder = auxProfundidad(v.getDerecho());
            profizq = auxProfundidad(v.getIzquierdo());
        }
        if(profizq > profder)
            return 1+profizq;
        else
            return 1+profder;

    }

    /**
     * Regresa el número de elementos en el árbol. El número de
     * elementos es el número de elementos que se han agregado al
     * árbol.
     * @return el número de elementos en el árbol.
     */
    public int getElementos() {
        // Aquí va su código.
        return elementos;
    }

    /**
     * Agrega un elemento al árbol.
     * @param elemento el elemento a agregar al árbol.
     * @return el vértice agregado al árbol que contiene el
     *         elemento.
     */
    public abstract VerticeArbolBinario<T> agrega(T elemento);

    /**
     * Elimina un elemento del árbol.
     * @param elemento el elemento a eliminar.
     */
    public abstract void elimina(T elemento);

    /**
     * Busca un elemento en el árbol. Si lo encuentra, regresa el
     * vértice que lo contiene; si no, regresa <tt>null</tt>.
     * @param elemento el elemento a buscar.
     * @return un vértice que contiene el elemento buscado si lo
     *         encuentra; <tt>null</tt> en otro caso.
     */
    public VerticeArbolBinario<T> busca(T elemento) {
        return auxBusca(elemento,raiz);
    }

    public VerticeArbolBinario<T> auxBusca(T elemento, VerticeArbolBinario<T> vertice){
        VerticeArbolBinario<T> vizq = null, vder = null;
        if(vertice == null)
            return null;
        else if(vertice.get().equals(elemento))
            return vertice;
        else if(vertice.hayIzquierdo())
            vizq = auxBusca(elemento,vertice.getIzquierdo());
        if(vizq != null)
            return vizq;
        else if(vertice.hayDerecho())
            vder = auxBusca(elemento, vertice.getDerecho());
        if(vder != null)
            return vder;
        else
            return null;
    }

    /**
     * Regresa el vértice que contiene la raíz del árbol.
     * @return el vértice que contiene la raíz del árbol.
     * @throws NoSuchElementException si el árbol es vacío.
     */
    public VerticeArbolBinario<T> raiz() {
        // Aquí va su código.
        return raiz;
    }

    /**
     * Regresa una representación en cadena del árbol.
     * @return una representación en cadena del árbol.
     */
    @Override public String toString() {
        /* Necesitamos la profundidad para saber cuántas ramas puede
           haber. */
        if (elementos == 0)
            return "";
        int p = profundidad() + 1;
        /* true == dibuja rama, false == dibuja espacio. */
        boolean[] rama = new boolean[p];
        for (int i = 0; i < p; i++)
            /* Al inicio, no dibujamos ninguna rama. */
            rama[i] = false;
        String s = aCadena(raiz, 0, rama);
        return s.substring(0, s.length()-1);
    }

    /**
     * Convierte el vértice en vértice. Método auxililar para hacer
     * esta audición en un único lugar.
     * @param verticeArbolBinario el vértice de árbol binario que queremos
     *        como vértice.
     * @return el vértice recibido visto como vértice.
     * @throws ClassCastException si el vértice no es instancia de
     *         {@link Vertice}.
     */
    protected Vertice<T> vertice(VerticeArbolBinario<T> verticeArbolBinario) {
        /* Tenemos que suprimir advertencias. */
        @SuppressWarnings("unchecked") Vertice<T> n = (Vertice<T>)verticeArbolBinario;
        return n;
    }

    /* Método auxiliar recursivo que hace todo el trabajo. */
    private String aCadena(Vertice<T> vertice, int nivel, boolean[] rama) {
        /* Primero que nada agregamos el vertice a la cadena. */
        String s = vertice + "\n";
        /* A partir de aquí, dibujamos rama en este nivel. */
        rama[nivel] = true;
        if (vertice.izquierdo != null && vertice.derecho != null) {
            /* Si hay vertice izquierdo Y derecho, dibujamos ramas o
             * espacios. */
            s += espacios(nivel, rama);
            /* Dibujamos el conector al hijo izquierdo. */
            s += "├─›";
            /* Recursivamente dibujamos el hijo izquierdo y sus
               descendientes. */
            s += aCadena(vertice.izquierdo, nivel+1, rama);
            /* Dibujamos ramas o espacios. */
            s += espacios(nivel, rama);
            /* Dibujamos el conector al hijo derecho. */
            s += "└─»";
            /* Como ya dibujamos el último hijo, ya no hay rama en
               este nivel. */
            rama[nivel] = false;
            /* Recursivamente dibujamos el hijo derecho y sus
               descendientes. */
            s += aCadena(vertice.derecho, nivel+1, rama);
        } else if (vertice.izquierdo != null) {
            /* Dibujamos ramas o espacios. */
            s += espacios(nivel, rama);
            /* Dibujamos el conector al hijo izquierdo. */
            s += "└─›";
            /* Como ya dibujamos el último hijo, ya no hay rama en
               este nivel. */
            rama[nivel] = false;
            /* Recursivamente dibujamos el hijo izquierdo y sus
               descendientes. */
            s += aCadena(vertice.izquierdo, nivel+1, rama);
        } else if (vertice.derecho != null) {
            /* Dibujamos ramas o espacios. */
            s += espacios(nivel, rama);
            /* Dibujamos el conector al hijo derecho. */
            s += "└─»";
            /* Como ya dibujamos el último hijo, ya no hay rama en
               este nivel. */
            rama[nivel] = false;
            /* Recursivamente dibujamos el hijo derecho y sus
               descendientes. */
            s += aCadena(vertice.derecho, nivel+1, rama);
        }
        return s;
    }

    /* Dibuja los espacios (incluidas las ramas, de ser necesarias)
       que van antes de un vértice. */
    private String espacios(int n, boolean[] rama) {
        String s = "";
        for (int i = 0; i < n; i++)
            if (rama[i])
                /* Rama: dibújala. */
                s += "│  ";
            else
                /* No rama: dibuja espacio. */
                s += "   ";
        return s;
    }
}

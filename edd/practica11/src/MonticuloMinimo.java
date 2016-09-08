package mx.unam.ciencias.edd;

import java.util.Iterator;
import java.util.NoSuchElementException;

/**
 * Clase para montículos mínimos (<i>min heaps</i>). Podemos crear
 * un montículo mínimo con <em>n</em> elementos en tiempo
 * <em>O</em>(<em>n</em>), y podemos agregar y actualizar elementos
 * en tiempo <em>O</em>(log <em>n</em>). Eliminar el elemento mínimo
 * también nos toma tiempo <em>O</em>(log <em>n</em>).
 */
public class MonticuloMinimo<T extends ComparableIndexable<T>>
    implements Iterable<T> {

    /* Clase privada para iteradores de montículos. */
    private class Iterador<T extends ComparableIndexable<T>> implements Iterator<T> {

        /* Índice del iterador. */
        private int indice;
        private MonticuloMinimo<T> monticulo;

        /* Construye un nuevo iterador, auxiliándose del montículo
         * mínimo. */
        public Iterador(MonticuloMinimo<T> monticulo) {
            // Aquí va su código.
            indice = 0;
            this.monticulo = monticulo;
        }

        /* Nos dice si hay un siguiente elemento. */
        public boolean hasNext() {
            // Aquí va su código.
            return indice < monticulo.siguiente;
        }

        /* Regresa el siguiente elemento. */
        public T next() {
            // Aquí va su código.
            if(hasNext())
                return monticulo.arbol[indice++];
            return null;
        }

        /* No lo implementamos: siempre lanza una excepción. */
        public void remove() {
            throw new UnsupportedOperationException();
        }
    }

    private int siguiente;
    /* Usamos un truco para poder utilizar arreglos genéricos. */
    private T[] arbol;

    /* Truco para crear arreglos genéricos. Es necesario hacerlo así
       por cómo Java implementa sus genéricos; de otra forma
       obtenemos advertencias del compilador. */
    @SuppressWarnings("unchecked") private T[] creaArregloGenerico(int n) {
        return (T[])(new ComparableIndexable[n]);
    }

    /**
     * Constructor sin parámetros. Es más eficiente usar {@link
     * #MonticuloMinimo(Lista)}, pero se ofrece este constructor por
     * completez.
     */
    public MonticuloMinimo() {
        // Aquí va su código.
        arbol = creaArregloGenerico(1);
        siguiente = 0;
    }

    /**
     * Constructor para montículo mínimo que recibe una lista. Es
     * más barato construir un montículo con todos sus elementos de
     * antemano (tiempo <i>O</i>(<i>n</i>)), que el insertándolos
     * uno por uno (tiempo <i>O</i>(<i>n</i> log <i>n</i>)).
     */
    public MonticuloMinimo(Lista<T> lista) {
        // Aquí va su código.
        arbol = creaArregloGenerico(lista.getLongitud());
        siguiente = 0;
        for(T e : lista) {
            e.setIndice(siguiente);
            arbol[siguiente++] = e;
        }
        auxRecursivo(siguiente/2);

    }

    private void auxRecursivo(int i) {
        int m = minimo(i,(2*i)+1,(2*i)+2);
        if(m == i) {
            //i--;
            if(i-1 >= 0)
                auxRecursivo(i-1);
            return;
        } 
        intercambia(i,m);
        auxRecursivo(m);
    }

    private int minimo(int i, int izq, int der) {
        int minimo;
        //existen ambos hijos
        if(siguiente > der) {
            if(arbol[der].compareTo(arbol[izq]) < 0) {
                if(arbol[der].compareTo(arbol[i]) < 0)
                    return der;
                return i;
            }
            else if(arbol[izq].compareTo(arbol[i]) < 0)
                    return izq;
            return i;

        } //existe solo el izquierdo
        else if(siguiente > izq)
            if(arbol[izq].compareTo(arbol[i]) < 0)
                return izq;
        return i;
    }

    private void intercambia(int i, int j) {
        T e = arbol[i];
        arbol[i] = arbol[j];
        arbol[i].setIndice(i);
        arbol[j] = e;
        arbol[j].setIndice(j);
    }

    /**
     * Agrega un nuevo elemento en el montículo.
     * @param elemento el elemento a agregar en el montículo.
     */
    public void agrega(T elemento) {
        // Aquí va su código.
        if(siguiente+1 > arbol.length) {
            T[] arbre = creaArregloGenerico(arbol.length*2);
            for(int i = 0; i < siguiente; i++) 
                arbre[i] = arbol[i];
            arbol = arbre;
        } 
        elemento.setIndice(siguiente);  
        arbol[siguiente] = elemento;
        siguiente += 1;
        reordena(elemento);
    }

    /**
     * Elimina el elemento mínimo del montículo.
     * @return el elemento mínimo del montículo.
     * @throws IllegalStateException si el montículo es vacío.
     */
    public T elimina() {
        // Aquí va su código.
        if(esVacio())
            throw new IllegalStateException();
        T e = arbol[0];
        arbol[0] = arbol[siguiente-1];
        arbol[0].setIndice(0);
        auxRecursivo2(0);
        siguiente--;
        return e;
    }

    private void auxRecursivo2(int i) {
        int m = minimo(i,(2*i)+1,(2*i)+2);
        if(m == i) {
            return;
        } 
        intercambia(i,m);
        auxRecursivo2(m);
    }

    /**
     * Nos dice si el montículo es vacío.
     * @return <tt>true</tt> si ya no hay elementos en el montículo,
     *         <tt>false</tt> en otro caso.
     */
    public boolean esVacio() {
        // Aquí va su código.
        return siguiente == 0;
    }

   /**
     * Reordena un elemento en el árbol.
     * @param elemento el elemento que hay que reordenar.
     */
    public void reordena(T elemento) {
        // Aquí va su código.
        int e = elemento.getIndice();
        int padre = (e-1)/2;
        if(e == 0 || padre < 0)
            return;
        /*
        if(arbol[padre] == null){
            elemento.setIndice(padre);
            arbol[padre] = elemento;
            reordena(arbol[padre]);
        }*/
        if(arbol[padre].compareTo(arbol[e]) > 0) {
            intercambia(padre,e);
            reordena(arbol[padre]);
        }
    }

    /**
     * Regresa el número de elementos en el montículo mínimo.
     * @return el número de elementos en el montículo mínimo.
     */
    public int getElementos() {
        // Aquí va su código.
        return siguiente;
    }

    /**
     * Regresa el <i>i</i>-ésimo elemento del árbol, por niveles.
     * @return el <i>i</i>-ésimo elemento del árbol, por niveles.
     * @throws NoSuchElementException si i es menor que cero, o
     *         mayor o igual que el número de elementos.
     */
    public T get(int i) {
        // Aquí va su código.
        if(i < 0 || i >= siguiente)
            throw new NoSuchElementException();
        return arbol[i];
    }

    /**
     * Regresa un iterador para iterar el montículo mínimo. El
     * montículo se itera en orden BFS.
     * @return un iterador para iterar el montículo mínimo.
     */
    public Iterator<T> iterator() {
        return new Iterador<T>(this);
    }
}

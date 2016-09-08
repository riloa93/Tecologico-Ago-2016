package mx.unam.ciencias.edd;

import java.util.Iterator;
import java.util.NoSuchElementException;

/**
 * <p>Clase para árboles binarios completos.</p>
 *
 * <p>Un árbol binario completo agrega y elimina elementos de tal
 * forma que el árbol siempre es lo más cercano posible a estar
 * lleno.<p>
 */
public class ArbolBinarioCompleto<T> extends ArbolBinario<T> {

    /* Clase privada para iteradores de árboles binarios
     * completos. */
    private class Iterador<T> implements Iterator<T> {

        Cola<VerticeArbolBinario<T>> cola = new Cola<VerticeArbolBinario<T>>();

        /* Constructor que recibe la raíz del árbol. */
        public Iterador(ArbolBinario<T>.Vertice<T> raiz) {
            // Aquí va su código.
            //cola = new Cola<VerticeArbolBinario<T>>();
            cola.mete(raiz);
        }

        /* Nos dice si hay un elemento siguiente. */
        @Override public boolean hasNext() {
            // Aquí va su código.
            return !cola.esVacia();
           
         }

        /* Regresa el elemento siguiente. */
        @Override public T next() {
            // Aquí va su código.
            if(hasNext()){
                VerticeArbolBinario<T> v = cola.saca();
                if(v.hayIzquierdo())
                    cola.mete(v.getIzquierdo());
                if(v.hayDerecho())
                    cola.mete(v.getDerecho());
                return v.get();
            }else
                throw new NoSuchElementException();
        }

        /* No lo implementamos: siempre lanza una excepción. */
        @Override public void remove() {
            throw new UnsupportedOperationException();
        }
    }

    /**
     * Constructor sin parámetros. Sencillamente ejecuta el
     * constructor sin parámetros de {@link ArbolBinario}.
     */
    public ArbolBinarioCompleto() { super(); }

    /**
     * Agrega un elemento al árbol binario completo. El nuevo
     * elemento se coloca a la derecha del último nivel, o a la
     * izquierda de un nuevo nivel.
     * @param elemento el elemento a agregar al árbol.
     * @return un iterador que apunta al vértice del árbol que
     *         contiene el elemento.
     */
    @Override public VerticeArbolBinario<T> agrega(T elemento) {
        Cola<Vertice<T>> c =  new Cola<Vertice<T>>();
        elementos += 1;
        if(raiz == null) {
            raiz = new Vertice<T>(elemento);
            return raiz;
        }
        else {
            c.mete(raiz);
            return auxAgrega(c,elemento);
        }
    }

    private VerticeArbolBinario<T> auxAgrega(Cola<Vertice<T>> c, T elemento){
        ArbolBinario<T>.Vertice<T> vertice = new ArbolBinario<T>.Vertice<T>(elemento);
        if(!c.esVacia())
            vertice = c.saca();
        else
            return null;
        
        if (!vertice.hayIzquierdo()) {
            vertice.izquierdo = new Vertice<T> (elemento);
            vertice.izquierdo.padre =  vertice;
            return vertice.izquierdo;
        } 

        else if (!vertice.hayDerecho()) {
            vertice.derecho = new Vertice<T> (elemento);
            vertice.derecho.padre = vertice;
            return vertice.derecho;
    
        } 

        else {
            c.mete(vertice.izquierdo);
            c.mete(vertice.derecho);
            return auxAgrega(c, elemento);
        }

             
    }

    /**
     * Elimina un elemento del árbol. El elemento a eliminar cambia
     * lugares con el último elemento del árbol al recorrerlo por
     * BFS, y entonces es eliminado.
     * @param elemento el elemento a eliminar.
     */
    @Override public void elimina(T elemento) {
        if(raiz == null)
            return;
        Vertice<T> sommet = null, aeliminar = vertice(busca(elemento));
        if(aeliminar == null)
            return;
        else {
            Cola<Vertice<T>> c = new Cola<>();
            c.mete(raiz);
            while(!c.esVacia()) {
                sommet = c.saca();
                if(sommet.hayIzquierdo())
                    c.mete(sommet.izquierdo);
                if(sommet.hayDerecho())
                    c.mete(sommet.derecho);
            }
            if(sommet == raiz)
                raiz = null;
            else {
                aeliminar.elemento = sommet.elemento;
                if(sommet.padre.izquierdo.equals(sommet))
                    sommet.padre.izquierdo = null;
                else
                    sommet.padre.derecho = null;
                //sommet.padre = null;
            }
            elementos--;
        }

    }

    /**
     * Regresa un iterador para iterar el árbol. El árbol se itera
     * en orden BFS.
     * @return un iterador para iterar el árbol.
     */
    @Override public Iterator<T> iterator() {
        // Aquí va su código.
        return new Iterador<T>(raiz);
    }
}

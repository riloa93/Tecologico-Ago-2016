package mx.unam.ciencias.edd;

/**
 * Clase para árboles rojinegros. Un árbol rojinegro cumple las
 * siguientes propiedades:
 *
 * <ol>
 *  <li>Todos los vértices son NEGROS o ROJOS.</li>
 *  <li>La raíz es NEGRA.</li>
 *  <li>Todas las hojas (<tt>null</tt>) son NEGRAS (al igual que la
 *      raíz).
 *  <li>Un vértice ROJO siempre tiene dos hijos NEGROS.</li>
 *  <li>Todo camino de un vértice a alguno de sus descendientes tiene
 *      el mismo número de vértices NEGROS.</li>
 * </ol>
 *
 * Los árboles rojinegros son autobalanceados, y por lo tanto las
 * operaciones de inserción, eliminación y búsqueda pueden
 * realizarse en <i>O</i>(log <i>n</i>).
 */
public class ArbolRojinegro<T extends Comparable<T>>
    extends ArbolBinarioOrdenado<T> {

    /**
     * Agrega un nuevo elemento al árbol. El método invoca al método
     * {@link ArbolBinarioOrdenado#agrega}, y después balancea el
     * árbol recoloreando vértices y girando el árbol como sea
     * necesario.
     * @param elemento el elemento a agregar.
     * @return un vértice que contiene al nuevo elemento.
     */
    @Override public VerticeArbolBinario<T> agrega(T elemento) {

        // Aquí va su código.
        Vertice<T> v = vertice(super.agrega(elemento));
        v.color = Color.ROJO;
        rebalanceoAgrega(v);
        return busca(elemento);
    }

    /**
     *  Método auxiliar para rebalancear el vértice recién agregado 
     *  y mantener las condiciones de un arbol RojiNegro válido
     */
    public void rebalanceoAgrega(Vertice<T> vertice) {
        //1er Caso
        if(vertice.padre == null) {
            vertice.color = Color.NEGRO;
            return;
        }
        //2do Caso
        if(vertice.padre.color == Color.NEGRO)
            return;

        //3er Caso el tio es rojo!
        Vertice<T> tio = tio(vertice);
        if(tio != null && tio.color == Color.ROJO) {
            Vertice<T> abuelo = abuelo(vertice);
            vertice.padre.color = Color.NEGRO;
            tio.color = Color.NEGRO;
            abuelo.color = Color.ROJO;
            rebalanceoAgrega(abuelo);
            return;
        }

        //4to Caso Están cruzados
        Vertice<T> abuelo = abuelo(vertice);
        if(vertice == vertice.padre.derecho && abuelo.izquierdo == vertice.padre) {
            giraIzquierda(vertice.padre);
            vertice = vertice.izquierdo;
        }
        else if(vertice == vertice.padre.izquierdo && abuelo.derecho == vertice.padre) {
            giraDerecha(vertice.padre);
            vertice = vertice.derecho;
        }

        //5to Caso No están cruzados
        abuelo = abuelo(vertice); //actualizacion
        vertice.padre.color = Color.NEGRO;
        abuelo.color = Color.ROJO;
        if(vertice.padre.derecho == vertice && abuelo.derecho == vertice.padre)
            giraIzquierda(abuelo);
        else if(vertice.padre.izquierdo == vertice && abuelo.izquierdo == vertice.padre)
            giraDerecha(abuelo);



        /*
        Vertice<T> abuelo = abuelo(vertice);
        if(abuelo != null) {
        //3er Caso
        if(abuelo.derecho != null && abuelo.derecho == vertice.padre) {
            if(abuelo.izquierdo != null && abuelo.izquierdo.color == Color.ROJO) {
                abuelo.izquierdo.color = Color.NEGRO;
                vertice.padre.color = Color.NEGRO;
                abuelo.color = Color.ROJO;
                rebalanceoAgrega(abuelo);
                return;
            }
        }
        else if(abuelo.izquierdo != null && abuelo.izquierdo == vertice.padre) {
            if(abuelo.derecho != null && abuelo.derecho.color == Color.ROJO) {
                abuelo.derecho.color = Color.NEGRO;
                vertice.padre.color = Color.NEGRO;
                abuelo.color = Color.ROJO;
                rebalanceoAgrega(abuelo);
                return;
            }
        }

        }

        abuelo = abuelo(vertice);
        if(abuelo != null) {
        //4to Caso
        if(abuelo.izquierdo != null && abuelo.izquierdo.derecho == vertice) {
            giraDerecha(vertice.padre);
            vertice = vertice.izquierdo; //?
        }
        else if(abuelo.derecho != null && abuelo.derecho.izquierdo == vertice) {
            giraIzquierda(vertice.padre);
            vertice = vertice.derecho; //?
        }
        }
        
        abuelo = abuelo(vertice);
        if(abuelo != null) {

        //5to caso
        if(abuelo.izquierdo != null && abuelo.izquierdo.izquierdo == vertice) {
            vertice.padre.color = Color.NEGRO;
            abuelo.color = Color.ROJO;
            giraDerecha(abuelo);
        }
        else if(abuelo.derecho != null && abuelo.derecho.derecho == vertice) {
            vertice.padre.color = Color.NEGRO;
            abuelo.color = Color.ROJO;
            giraIzquierda(abuelo);
        }

        }
         */

    }

    private Vertice<T> abuelo(Vertice<T> vertice) {
        if(vertice == null)
            return null;
        if(vertice.padre == null)
            return null;
        return vertice.padre.padre;
    }

    private Vertice<T> tio(Vertice<T> vertice) {
        if(vertice == null) 
            return null;
        Vertice<T> abuelo = abuelo(vertice);
        Vertice<T> v = null;
        if(abuelo != null) {
            if(abuelo.izquierdo == vertice.padre)
                v = abuelo.derecho;
            else
                v = abuelo.izquierdo;
        }
        return v;
    }

    /**
     * Elimina un elemento del árbol. El método elimina el vértice que
     * contiene el elemento, y recolorea y gira el árbol como sea
     * necesario para rebalancearlo.
     * @param elemento el elemento a eliminar del árbol.
     */
    @Override public void elimina(T elemento) {
        //Paso 1
        Vertice<T> v = vertice(busca(elemento));
        if(v == null)
            return;
        elimina(v);
        elementos--;
    }

    private void elimina(Vertice<T> v) {
        //Paso 2
        Vertice<T> a = buscaVerticeAnterior(v);
        //Paso 3
        if(a != null) {
            intercambia(v,a);
            v = a;
        }
        //creacion del vertice fantasma, paso 4 y 5 
        Vertice<T> h = new Vertice<T>(null);
        //En el caso de que sea v sea hoja, asignamos el fantasma como izquierdo de v
        if(!v.hayDerecho() && !v.hayIzquierdo()) {
            h.color = Color.NEGRO;
            v.izquierdo = h;
            //h.padre = v;
        } 
        //De lo contrario podemos asignarle el unico hijo que sabemos que tiene
        else if(v.hayDerecho())
            h = v.derecho;
        else
            h = v.izquierdo;
        //Paso 6 Subir h
        h.padre = v.padre;
        if(v.padre != null) {
            if(v.padre.izquierdo == v)
                v.padre.izquierdo = h;
            else
                v.padre.derecho = h;
        }
        //Paso 7
        else
            raiz = h;
        //Paso 8
        if(//v.color == Color.NEGRO && 
            h.color == Color.ROJO) {
            h.color = Color.NEGRO;
            return;
        }
        if (v.color == Color.NEGRO && h.elemento != null) {
            h.color = Color.NEGRO;
            return;
        }
        //Paso 9
        if(v.color == Color.NEGRO && h.color == Color.NEGRO){
            rebalanceoElimina1(h);
            if(h.elemento == null)
                if(raiz == h)
                    raiz = h = null;
                else {
                    if(v.padre.derecho == h)
                        v.padre.derecho = null;
                    else
                        v.padre.izquierdo = null;
                    //h = null;
                    //v = null;
                }
            return;
            
        }
        //Paso10
        //if(v.color == Color.ROJO)
            if(h.elemento == null) 
                if(raiz == h)
                    raiz = h = null;
                else {
                    if(v.padre.izquierdo == h)
                        v.padre.izquierdo = null;
                    else
                        v.padre.derecho = null;
                    //h = null;
                    //v = null;
            }
        
    
    }

    private void ghostbuster(Vertice<T> v) {
        if (v == null)
            return;
        if (v.izquierdo != null && v.izquierdo.elemento == null)
            v.izquierdo = null;
        if (v.derecho != null && v.derecho.elemento == null)
            v.derecho = null;
    }



    
    private void rebalanceoElimina1(Vertice<T> v) {
        if(v.padre == null) {
            raiz = v;
            return;
        }
        else
            rebalanceoElimina2(v);
    }

    private void rebalanceoElimina2(Vertice<T> v) {
        Vertice<T> hermano = hermano(v);
        VerticeArbolBinario<T> z = hermano.getPadre(); //Comprobacion
        if(hermano.color == Color.ROJO) {
            v.padre.color = Color.ROJO;
            hermano.color = Color.NEGRO;
            if(v.padre.derecho == v)
                giraDerecha(v.padre);
            else
                giraIzquierda(v.padre);
        }
        rebalanceoElimina3(v);
    }

    private void rebalanceoElimina3(Vertice<T> v) {
        Vertice<T> hermano = hermano(v);
        if(hermano != null)
        if(v.padre.color == Color.NEGRO && hermano.color == Color.NEGRO && colorNegro(hermano.izquierdo) &&
            colorNegro(hermano.derecho)) {
                hermano.color = Color.ROJO;
                rebalanceoElimina1(v.padre);
                //return; //??
        } 
        else
            rebalanceoElimina4(v);
    }

    private void rebalanceoElimina4(Vertice<T> v) {
        Vertice<T> hermano = hermano(v);
        
        if(v.padre.color == Color.ROJO && 
            hermano.color == Color.NEGRO && 
            colorNegro(hermano.izquierdo) && colorNegro(hermano.derecho)) {
                hermano.color = Color.ROJO;
                v.padre.color = Color.NEGRO;
                //return; //??
        }
        else
            rebalanceoElimina5(v);
    }

    private void rebalanceoElimina5(Vertice<T> v) {
        Vertice<T> hermano = hermano(v);
    
        if(v.padre.izquierdo == v && 
            hermano.color == Color.NEGRO &&
            !colorNegro(hermano.izquierdo) && colorNegro(hermano.derecho)) {
            hermano.color = Color.ROJO;
            hermano.izquierdo.color = Color.NEGRO;
            giraDerecha(hermano);
        }
        else if (v.padre.derecho == v &&
            hermano.color == Color.NEGRO &&
            !colorNegro(hermano.derecho) && colorNegro(hermano.izquierdo)) {
            hermano.color = Color.ROJO;
            hermano.derecho.color = Color.NEGRO;
            giraIzquierda(hermano);
        }
        /*
        if(hermano.color == Color.NEGRO &&
             (colorNegro(hermano.izquierdo) && !colorNegro(hermano.derecho)) || 
              (!colorNegro(hermano.izquierdo) && colorNegro(hermano.derecho))) {
                hermano.color = Color.ROJO; 
                if(!colorNegro(hermano.izquierdo))
                    hermano.izquierdo.color = Color.NEGRO;
                if(!colorNegro(hermano.derecho))
                    hermano.derecho.color = Color.NEGRO;
                if(v.padre.derecho == v)
                    giraIzquierda(hermano);
                else
                    giraDerecha(hermano);
        }
        */
        rebalanceoElimina6(v);
    }

    private void rebalanceoElimina6(Vertice<T> v) {
        Vertice<T> hermano = hermano(v);
     
        hermano.color = v.padre.color;
        v.padre.color = Color.NEGRO;
        if(v.padre.derecho == v) {
            hermano.izquierdo.color = Color.NEGRO;
            giraDerecha(v.padre);
        }
        else {
            hermano.derecho.color = Color.NEGRO;
            giraIzquierda(v.padre);
        }

    }



/*
    private void rebalanceoElimina(Vertice<T> v) {
        //Caso 1
        if(v.padre == null) {
            raiz = v;
            return;
        }
        //Caso 2
        Vertice<T> hermano = hermano(v);
        if(hermano.color == Color.ROJO) {
            v.padre.color = Color.ROJO;
            hermano.color = Color.NEGRO;
            if(v.padre.derecho == v)
                giraDerecha(v.padre);
            else
                giraIzquierda(v.padre);
            //hermano = hermano(v); //Actualizacion
        }
        //Caso 3 nota: verificar las condiciones
        //else 
        hermano = hermano(v);
        if(v.padre.color == Color.NEGRO && hermano.color == Color.NEGRO && colorNegro(hermano.izquierdo) &&
            colorNegro(hermano.derecho)) {
                hermano.color = Color.ROJO;
                rebalanceoElimina(v.padre);
                return;
        }

        //Caso 4
        else 
        if(v.padre.color == Color.ROJO && 
            hermano.color == Color.NEGRO && 
            colorNegro(hermano.izquierdo) && colorNegro(hermano.derecho)) {
                v.padre.color = Color.NEGRO;
                hermano.color = Color.ROJO;
                return; //??
        }
        //Caso 5 revisar actualizacion de referencias
        else 
        if(hermano.color == Color.NEGRO &&
             (colorNegro(hermano.izquierdo) && !colorNegro(hermano.derecho)) || 
              (!colorNegro(hermano.izquierdo) && colorNegro(hermano.derecho))) {
                hermano.color = Color.ROJO; 
                if(!colorNegro(hermano.izquierdo))
                    hermano.izquierdo.color = Color.NEGRO;
                if(!colorNegro(hermano.derecho))
                    hermano.derecho.color = Color.NEGRO;
                if(v.padre.derecho == v)
                    giraIzquierda(hermano);
                else
                    giraDerecha(hermano);
                hermano = hermano(v); //actualizacion
        }

        //Caso 6 OCURRE
        hermano = hermano(v);
        
        hermano.color = v.padre.color;
        v.padre.color = Color.NEGRO;
        if(v.padre.derecho == v) {
            hermano.izquierdo.color = Color.NEGRO;
            giraDerecha(v.padre);
        }
        else {
            hermano.derecho.color = Color.NEGRO;
            giraIzquierda(v.padre);
        }
    }
    */
    
    private Vertice<T> hermano(Vertice<T> v) {
        if(v.padre.derecho == v)
            return v.padre.izquierdo;
        else
            return v.padre.derecho;
    }

    private boolean colorNegro(Vertice<T> v) {
        if(v == null || v.color == Color.NEGRO)
            return true;
        else
            return false;
    }

}
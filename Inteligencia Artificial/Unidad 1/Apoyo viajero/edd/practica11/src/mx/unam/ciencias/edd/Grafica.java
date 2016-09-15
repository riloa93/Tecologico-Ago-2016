package mx.unam.ciencias.edd;

import java.util.Iterator;
import java.util.NoSuchElementException;


/**
 * Clase para gráficas. Una gráfica es un conjunto de vértices y
 * aristas, tales que las aristas son un subconjunto del producto
 * cruz de los vértices.
 */
public class Grafica<T> implements Iterable<T> {

    /* Clase privada para iteradores de gráficas. */
    private class Iterador<T> implements Iterator<T> {

        /* Iterador auxiliar. */
        private Iterator<Grafica<T>.Vertice<T>> iterador;

        /* Construye un nuevo iterador, auxiliándose del diccionario
         * de vértices. */
        public Iterador(Grafica<T> grafica) {
            iterador = grafica.vertices.iterator();
        }

        /* Nos dice si hay un siguiente elemento. */
        public boolean hasNext() {
            return iterador.hasNext();
        }

        /* Regresa el siguiente elemento. */
        public T next() {
            return iterador.next().elemento;
        }

        /* No lo implementamos: siempre lanza una excepción. */
        public void remove() {
            throw new UnsupportedOperationException();
        }
    }

    /* Aristas para gráficas; para poder guardar el peso de las
     * aristas. */
    private class Arista<T> {

        /* El vecino del vértice. */
        public Grafica<T>.Vertice<T> vecino;
        /* El peso de arista conectando al vértice con el vecino. */
        public double peso;

        public Arista(Grafica<T>.Vertice<T> vecino, double peso) {
            this.vecino = vecino;
            this.peso = peso;
        }
    }

    /* Vertices para gráficas; implementan la interfaz
     * ComparableIndexable y VerticeGrafica */
    private class Vertice<T> implements ComparableIndexable<Vertice<T>>,
        VerticeGrafica<T> {

        /* Iterador para las vecinos del vértice. */
        private class IteradorVecinos implements Iterator<VerticeGrafica<T>> {

            /* Iterador auxiliar. */
            private Iterator<Grafica<T>.Arista<T>> iterador;

            /* Construye un nuevo iterador, auxiliándose del
             * diccionario de vecinos. */
            public IteradorVecinos(Iterator<Grafica<T>.Arista<T>> iterador) {
                this.iterador = iterador;
            }

            /* Nos dice si hay un siguiente vecino. */
            public boolean hasNext() {
                return iterador.hasNext();
            }

            /* Regresa el siguiente vecino. La audición es
             * inevitable. */
            public VerticeGrafica<T> next() {
                Grafica<T>.Arista<T> arista = iterador.next();
                return (VerticeGrafica<T>)arista.vecino;
            }

            /* No lo implementamos: siempre lanza una excepción. */
            public void remove() {
                throw new UnsupportedOperationException();
            }
        }

        /* El elemento del vértice. */
        public T elemento;
        /* El color del vértice. */
        public Color color;
        /* La distancia del vértice. */
        public double distancia;
        /* El índice del vértice. */
        public int indice;
        /* El diccionario de aristas que conectan al vértice con sus
         * vecinos. */
        public Diccionario<T, Grafica<T>.Arista<T>> aristas;

        /* Crea un nuevo vértice a partir de un elemento. */
        public Vertice(T elemento) {
            this.elemento = elemento;
            color = Color.NINGUNO;
            aristas = new Diccionario<T,Grafica<T>.Arista<T>>();
        }

        /* Regresa el elemento del vértice. */
        public T getElemento() {
            return elemento;
        }

        /* Regresa el grado del vértice. */
        public int getGrado() {
            return aristas.getTotal();
        }

        /* Regresa el color del vértice. */
        public Color getColor() {
            return color;
        }

        /* Define el color del vértice. */
        public void setColor(Color color) {
            this.color = color;
        }

        /* Regresa un iterador para los vecinos. */
        public Iterator<VerticeGrafica<T>> iterator() {
            return new IteradorVecinos(aristas.iterator());
        }

        /* Define el índice del vértice. */
        public void setIndice(int indice) {
            this.indice = indice;
        }

        /* Regresa el índice del vértice. */
        public int getIndice() {
            return indice;
        }

        /* Compara dos vértices por distancia. */
        public int compareTo(Vertice<T> vertice) {
            if(distancia < vertice.distancia)
                return -1;
            if(distancia > vertice.distancia)
                return 1;
            return 0;
        }
    }

    /* Vértices. */
    private Diccionario<T, Vertice<T>> vertices;
    /* Número de aristas. */
    private int aristas;

    /**
     * Constructor único.
     */
    public Grafica() {
        vertices = new Diccionario<T, Vertice<T>>();
        aristas = 0;
    }

    /**
     * Regresa el número de vértices.
     * @return el número de vértices.
     */
    public int getVertices() {
        return vertices.getTotal();
    }

    /**
     * Regresa el número de aristas.
     * @return el número de aristas.
     */
    public int getAristas() {
        return aristas;
    }

    /**
     * Agrega un nuevo elemento a la gráfica.
     * @param elemento el elemento a agregar.
     * @throws IllegalArgumentException si el elemento ya había sido
     *         agregado a la gráfica.
     */
    public void agrega(T elemento) {
        if(contiene(elemento))
            throw new IllegalArgumentException();
        vertices.agrega(elemento,new Vertice<T>(elemento));
    }

    /**
     * Conecta dos elementos de la gráfica. Los elementos deben
     * estar en la gráfica. El peso de la arista que conecte a los
     * elementos será 1.
     * @param a el primer elemento a conectar.
     * @param b el segundo elemento a conectar.
     * @throws NoSuchElementException si a o b no son elementos de
     *         la gráfica.
     * @throws IllegalArgumentException si a o b ya están
     *         conectados, o si a es igual a b.
     */
    public void conecta(T a, T b) {
        if(!contiene(a) || !contiene(b))
            throw new NoSuchElementException();
        if(a == b || sonVecinos(a,b))
            throw new IllegalArgumentException();
        vertices.get(a).aristas.agrega(b,new Arista<T>(vertices.get(b),1));
        vertices.get(b).aristas.agrega(a,new Arista<T>(vertices.get(a),1));
        aristas++;
    }

    /**
     * Conecta dos elementos de la gráfica. Los elementos deben
     * estar en la gráfica.
     * @param a el primer elemento a conectar.
     * @param b el segundo elemento a conectar.
     * @param peso el peso de la nueva arista.
     * @throws NoSuchElementException si a o b no son elementos de
     *         la gráfica.
     * @throws IllegalArgumentException si a o b ya están
     *         conectados, o si a es igual a b.
     */
    public void conecta(T a, T b, double peso) {
         if(!contiene(a) || !contiene(b))
            throw new NoSuchElementException();
        if(a == b || sonVecinos(a,b))
            throw new IllegalArgumentException();
        vertices.get(a).aristas.agrega(b,new Arista<T>(vertices.get(b),peso));
        vertices.get(b).aristas.agrega(a,new Arista<T>(vertices.get(a),peso));
        aristas++;
    }

    /**
     * Desconecta dos elementos de la gráfica. Los elementos deben
     * estar en la gráfica y estar conectados entre ellos.
     * @param a el primer elemento a desconectar.
     * @param b el segundo elemento a desconectar.
     * @throws NoSuchElementException si a o b no son elementos de
     *         la gráfica.
     * @throws IllegalArgumentException si a o b no están
     *         conectados.
     */
    public void desconecta(T a, T b) {
        if(!contiene(a) || !contiene(b))
            throw new NoSuchElementException();
         if(!sonVecinos(a,b) || a == b)
            throw new IllegalArgumentException();
        vertices.get(a).aristas.elimina(b);
        vertices.get(b).aristas.elimina(a);
        aristas--;
    }

    /**
     * Nos dice si el elemento está contenido en la gráfica.
     * @return <tt>true</tt> si el elemento está contenido en la
     *         gráfica, <tt>false</tt> en otro caso.
     */
    public boolean contiene(T elemento) {
        return vertices.contiene(elemento);
    }

    /**
     * Elimina un elemento de la gráfica. El elemento tiene que
     * estar contenido en la gráfica.
     * @param elemento el elemento a eliminar.
     * @throws NoSuchElementException si el elemento no está
     *         contenido en la gráfica.
     */
    public void elimina(T elemento) {
        if(!contiene(elemento))
            throw new NoSuchElementException();
        for(Arista<T> arista : vertices.get(elemento).aristas)
            desconecta(elemento,arista.vecino.elemento);
        vertices.elimina(elemento);
    }

    /**
     * Nos dice si dos elementos de la gráfica están conectados. Los
     * elementos deben estar en la gráfica.
     * @param a el primer elemento.
     * @param b el segundo elemento.
     * @return <tt>true</tt> si a y b son vecinos, <tt>false</tt> en
     *         otro caso.
     * @throws NoSuchElementException si a o b no son elementos de
     *         la gráfica.
     */
    public boolean sonVecinos(T a, T b) {
        if(!contiene(a) || !contiene(b))
            throw new NoSuchElementException();
        return vertices.get(a).aristas.contiene(b);
    }

    /**
     * Regresa el peso de la arista que comparten los vértices que
     * contienen a los elementos recibidos.
     * @param a el primer elemento.
     * @param b el segundo elemento.
     * @return el peso de la arista que comparten los vértices que
     *         contienen a los elementos recibidos, o -1 si los
     *         elementos no están conectados.
     * @throws NoSuchElementException si a o b no son elementos de
     *         la gráfica.
     */
    public double getPeso(T a, T b) {
        if(!contiene(a) || !contiene(b))
            throw new NoSuchElementException();
        if(!sonVecinos(a,b))
            return -1;
        return vertices.get(a).aristas.get(b).peso;
    }

    /**
     * Regresa el vértice correspondiente el elemento recibido.
     * @throws NoSuchElementException si elemento no es elemento de
     *         la gráfica.
     * @return el vértice correspondiente el elemento recibido.
     */
    public VerticeGrafica<T> vertice(T elemento) {
        if(!contiene(elemento))
            throw new NoSuchElementException();
        return vertices.get(elemento);
    }

    /**
     * Realiza la acción recibida en cada uno de los vértices de la
     * gráfica, en el orden en que fueron agregados.
     * @param accion la acción a realizar.
     */
    public void paraCadaVertice(AccionVerticeGrafica<T> accion) {
        for(Vertice<T> v : vertices)
            accion.actua(v);
    }

    /**
     * Realiza la acción recibida en todos los vértices de la
     * gráfica, en el orden determinado por BFS, comenzando por el
     * vértice correspondiente al elemento recibido. Al terminar el
     * método, todos los vértices tendrán color {@link
     * Color#NINGUNO}.
     * @param elemento el elemento sobre cuyo vértice queremos
     *        comenzar el recorrido.
     * @param accion la acción a realizar.
     * @throws NoSuchElementException si el elemento no está en la
     *         gráfica.
     */
    public void bfs(T elemento, AccionVerticeGrafica<T> accion) {
        if(!contiene(elemento))
            throw new NoSuchElementException();
        Cola<Vertice<T>> c = new Cola<Vertice<T>>();
        vertices.get(elemento).color = Color.NINGUNO;
        c.mete(vertices.get(elemento));
        bfs_dfs(c,accion);
    }

    /**
     * Realiza la acción recibida en todos los vértices de la
     * gráfica, en el orden determinado por DFS, comenzando por el
     * vértice correspondiente al elemento recibido. Al terminar el
     * método, todos los vértices tendrán color {@link
     * Color#NINGUNO}.
     * @param elemento el elemento sobre cuyo vértice queremos
     *        comenzar el recorrido.
     * @param accion la acción a realizar.
     * @throws NoSuchElementException si el elemento no está en la
     *         gráfica.
     */
    public void dfs(T elemento, AccionVerticeGrafica<T> accion) {
        if(!contiene(elemento))
            throw new NoSuchElementException();
        Pila<Vertice<T>> p = new Pila<Vertice<T>>();
        vertices.get(elemento).color = Color.NINGUNO;
        p.mete(vertices.get(elemento));
        bfs_dfs(p,accion);
    }

    /**
     * Método auxiliar para bfs y dfs
     * @param m, una instancia de la clase MeteSaca, ya sea una pila o una cola
     * @param a, la acción a realizar con los vertices de la estructura
     */
    private void bfs_dfs(MeteSaca<Vertice<T>> m, AccionVerticeGrafica<T> a) {
        while(!m.esVacia()) {
            Vertice<T> va = m.saca();
            va.color = Color.ROJO;
            a.actua(va);
            for(Arista<T> arista : va.aristas)
                if(arista.vecino.color != Color.ROJO) {
                    m.mete(arista.vecino);
                    arista.vecino.color = Color.ROJO;
                }
        }
        for(Vertice<T> v1 : vertices)
            v1.color = Color.NINGUNO;
    }

    /**
     * Regresa un iterador para iterar la gráfica. La gráfica se
     * itera en el orden en que fueron agregados sus elementos.
     * @return un iterador para iterar la gráfica.
     */
    @Override public Iterator<T> iterator() {
        return new Iterador<T>(this);
    }

    /**
     * Calcula una trayectoria de distancia mínima entre dos
     * vértices.
     * @param origen el vértice de origen.
     * @param destino el vértice de destino.
     * @return Una lista con vértices de la gráfica, tal que forman
     *         una trayectoria de distancia mínima entre los
     *         vértices <tt>a</tt> y <tt>b</tt>. Si los elementos se
     *         encuentran en componentes conexos distintos, el
     *         algoritmo regresa una lista vacía.
     * @throws NoSuchElementException si alguno de los dos elementos
     *         no está en la gráfica.
     */
    public Lista<VerticeGrafica<T>> trayectoriaMinima(T origen, T destino) {
        if(!contiene(origen) || !contiene(destino))
            throw new NoSuchElementException();
        Vertice<T> ori = vertices.get(origen);
        Vertice<T> dest = vertices.get(destino);
        Lista<VerticeGrafica<T>> l = new Lista<>();
        Cola<Vertice<T>> cola = new Cola<>();
        cola.mete(ori);
        ori.color=Color.ROJO;
        if(!construye(cola,dest))
            return l;
        l.agregaFinal(dest);
        reconstruye(dest,l);
        return l;
    }

    /**
     * Método que construye la trayectoria mínima 
     */
    private boolean construye(Cola<Vertice<T>> cola, Vertice<T> destino){
        if(cola.esVacia())
            return false;
        Vertice<T> v = cola.saca();
        if(v == destino)
            return true;
        for(Arista<T> a : v.aristas){
            if(a.vecino.color != Color.ROJO){
                a.vecino.color=Color.ROJO;
                a.vecino.distancia = v.distancia + 1;
                cola.mete(a.vecino);
            }
        }
        return construye(cola,destino);
    }

    /** 
     * Método que hace el regreso para la trayectoria mínima 
     */
    private void reconstruye(Vertice<T> v, Lista<VerticeGrafica<T>> lista){
        if(v.distancia == 0)
            return;
        for(Arista<T> a : v.aristas){
            if(a.vecino.distancia + 1 == v.distancia){
                lista.agregaInicio(a.vecino);
                reconstruye(a.vecino,lista);
                break;
            }   
        }
    }


    /**
     * Calcula la ruta de peso mínimo entre el elemento de origen y
     * el elemento de destino.
     * @param origen el vértice origen.
     * @param destino el vértice destino.
     * @return una trayectoria de peso mínimo entre el vértice
     *         <tt>origen</tt> y el vértice <tt>destino</tt>. Si los
     *         vértices están en componentes conexas distintas,
     *         regresa una lista vacía.
     * @throws NoSuchElementException si alguno de los dos elementos
     *         no está en la gráfica.
     */
    public Lista<VerticeGrafica<T>> dijkstra(T ori, T dest) {
        if(!contiene(ori) || !contiene(dest))
            throw new NoSuchElementException();
         Vertice<T> origen  = vertices.get(ori),
                    destino = vertices.get(dest);
        /* Todos los vértices tienen distancia infinta */
        for(Vertice<T> v : vertices)
            v.distancia = Double.POSITIVE_INFINITY;
        /* La distancia del origen es 0 */
        origen.distancia = 0;
        /* Se crea un montículo con los vértices de la gráfica y una lista */
        Lista<VerticeGrafica<T>> dijkstrAlgorythm = new Lista<VerticeGrafica<T>>();
        Lista<Vertice<T>> lista = new Lista<Vertice<T>>();
        for(Vertice<T> v : vertices)
            lista.agregaInicio(v);
        MonticuloMinimo<Vertice<T>> monticulo = new MonticuloMinimo<Vertice<T>>(lista);
        while(!monticulo.esVacio()){
            Vertice<T> v = monticulo.elimina();
            for(Arista<T> arista : v.aristas){
                if((v.distancia + arista.peso) < arista.vecino.distancia){
                    arista.vecino.distancia = v.distancia + arista.peso;
                    monticulo.reordena(arista.vecino);
                }
            }
        }
        /* Se verifica si alguno de los vértices están en componentes conexas distintas */
        if(origen.distancia == Double.POSITIVE_INFINITY || destino.distancia == Double.POSITIVE_INFINITY)
            return dijkstrAlgorythm;
        return dijkstra(destino,dijkstrAlgorythm);
    }

    /**
     * Método auxiliar que hace el regreso desde el vértice destino para dijkstra 
     */
    private Lista<VerticeGrafica<T>> dijkstra(Vertice<T> vertice,Lista<VerticeGrafica<T>> lista){
        lista.agregaInicio(vertice);
        if(vertice.distancia == 0)
            return lista;
        Vertice<T> v = null;
        for(Arista<T> arista : vertice.aristas){
            if(vertice.distancia - arista.peso == arista.vecino.distancia)
                 v = arista.vecino;
        } 
        return dijkstra(v,lista);
    }

//SVG

    /**
     * Genera codigo para Scalable Vector Graphics (SVG) y obtener una
     * representación de nuestra abstracción de la estructura de datos Gráfica.
     * El método itera sobre el diccionario de vértices, llamando por cada uno al método que lo dibujará.
     * @return String la cadena del codigo xml.
     */
    public String generaScalableVectorGraphics() {
        // Aquí va su código.
        genesis_SVG();
        double radio = calculaRadio(),
                alto = (radio*2)+50,
                ancho = alto;
        String svg = "<?xml version = \"1.0\" encoding = \"UTF-8\" ?>\n<svg width = \""+ancho+"\" height = \""+alto+"\">\n"+
                        "<rect x=\"0\" y=\"0\" width=\""+ancho+"\" height=\""+alto+"\" style=\"fill:rgb(248,248,255);stroke-width:0;stroke:rgb(0,0,0)\"/>\n";
        for(Vertice<T> v : vertices)
            svg = dibujarVertice(svg,v);
        return svg + "\n</svg>";
    }

    /**
     * Método auxiliar iterativo para 'dibujar' cada vértice de la gráfica,
     * con su respectivo elemento y sus respectivas adyacencias.
     * Este método itera sobre las aristas del vértice llamando en cada iteración al método dibujarArista()
     * @param svg la cadena original a la que agregará las líneas de codigo XML necesarias.
     * @param v el vértice que se dibujará junto con todas sus aristas.
     * @return String la cadena original concatenada con el nuevo código pertinente.
     */
    private String dibujarVertice(String svg, Vertice<T> v) {
        //dibujar las aristas primero
        for(Arista<T> arista : v.aristas) 
            if(arista.vecino.color == Color.NEGRO)
                svg += dibujarArista(calculaX(v),calculaY(v),arista.vecino);
        //finalmente dibujar el vertice
        double yelem = calculaY(v)+6;
        svg +="<circle cx=\""+calculaX(v)+"\" cy=\""+calculaY(v)+"\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" />\n";
        svg +="<text fill=\"black\" font-family=\"sans-serif\" font-size=\""+tDeLetra(v.elemento)+"\" x=\""+calculaX(v)+"\" y=\""+yelem+"\"\ntext-anchor=\"middle\">"+cortarElemento(v.elemento)+"</text>\n";
        v.color = Color.ROJO;
        return svg;
    }

    /**
     * Método auxiliar para dibujarVertice() que a partir de la coordenada (x,y) que recibe
     * y el vertice vecino genera el codigo para representar una arista con una linea con coordenadas
     * (x1,y1) = (x,y) que recibe y sus (x2,y2) con el (x,y) que corresponde al vértice.
     * @param x la coordenada x del vértice que recibió dibujarVertice().
     * @param y la coordenada y del vértice que recibió dibujarVertice().
     * @param vecino el vertice que contenía la arista en la iteración de dibujarVertice().
     * @return String el código XML necesario para dibujar una arista listo para concatenarse a la cadena total.
     */
    private String dibujarArista(double x, double y, Vertice<T> vecino) {
        String svg = "";
        svg += "<line x1=\""+x+"\" y1=\""+y+"\" x2=\""+calculaX(vecino)+"\" y2=\""+calculaY(vecino)+"\" stroke=\"black\" stroke-width=\"2\" />\n";
        return svg;
    }

    /**
     * Método auxiliar para determinar el tamaño de la letra del elemento en cadena del vértice.
     * El tamaño disminuye entre mayor es la longitud del elemento en cadena, pero solo 
     * entre 6 y 9, pasando esa longitud determina el tamaño 10 pues no se incluirá todo el elemento en cadena
     * sobre dentro del vértice.
     * @param elemento el elemento a medir para determinar el tamaño de letra.
     * @return la medida correspondiente en cadena para incluir en el codigo.
     */
    private String tDeLetra(T elemento) {
        int longitud = elemento.toString().length();
        if(longitud <= 3)
            return "20";
        if(longitud > 3 && longitud <= 6)
            return "10";
        if(longitud > 6 && longitud <= 9)
            return "15";
        return "10";
    }

    /**
     * Método auxiliar para seleccionar los primeros 5 caracteres de un elemento con
     * representación en cadena de longitud mayor a 9. 
     * Si la longitud no sobrepasa ese límite, simplemente devuelve la representación
     * en cadena completa del elemento.
     * @param elemento el elemento a representar en cadena.
     * @return la cadena con la representación del elemento.
     */
    private String cortarElemento(T elemento) {
        if(elemento.toString().length() > 9)
            return elemento.toString().substring(0,5)+"..";
        return elemento.toString();
    }

    /**
     * Método auxiliar para calcular la posición que le corresponde al vértice en la circunferencia imaginaria
     * basándose en la obtención de coordenadas polares. rsenø
     * @param v el vértice del cual queremos obtener la coordenada X para el SVG
     * @return double la coordenada x que corresponde al vértice recibido.
     */
    private double calculaX(Vertice<T> v) {
        double radio = calculaRadio();
        double teta = ((2*Math.PI)/vertices.getTotal())*v.getIndice();
        return 25 + radio - (radio*Math.sin(teta)); // (radio*Math.sin(teta)) + radio + 75
    }

     /**
     * Método auxiliar para calcular la posición que le corresponde al vértice en la circunferencia imaginaria
     * basándose en la obtención de coordenadas polares. rcosø
     * @param v el vértice del cual queremos obtener la coordenada y para el SVG
     * @return double la coordenada y que corresponde al vértice recibido.
     */
    private double calculaY(Vertice<T> v) {
        double radio = calculaRadio();
        double teta = ((2*Math.PI)/vertices.getTotal())*v.getIndice();
        return 25 + radio - (radio*Math.cos(teta)); // (radio*Math.cos(teta)) + radio + 75
    }

    /**
     * Método auxiliar para calcular el radio de la circunferencia imaginaria,
     * sobre la que se posicionarán los vértices.
     * Son múltiplos de 25, por el tamaño considerado para el total de vértices.
     * @return double el tamaño del radio. 
     */
    private double calculaRadio() {
        return 25*vertices.getTotal();
    }

    /**
     * Método auxiliar para dar un mismo color y un índice distinto a todos los vértices de la gráfica
     * Note que se utiliza antes que nada en el método generaScalableVectorGraphics() con el fin
     * de no repetir código para las aristas (aunque no sea perceptible en la imagen, en el código sí)
     * gracias al cambio de color y usar el indice para el calculo de las coordenadas para cada vértice
     * en los métodos calculaX() y calculaY().
     */
    private void genesis_SVG() {
        int i = 0;
        for(Vertice<T> v : vertices) {
            v.color = Color.NEGRO;
            v.setIndice(i++);
        }
    }

    /**
     * Genera codigo para Scalable Vector Graphics (SVG) y obtener una
     * representación de nuestra abstracción de la estructura de datos Gráfica además de
     * resaltar la trayectoria que recibe.
     * Simplemente se auxilia del método sin parámetros con el mismo nombre para dibujar la
     * totalidad de la gŕáfica y encima los vertices de la lista, para resaltar la trayectoria
     * con un color distinto de las aristas y los vértices restantes de la gráfica.
     * @param l la lista de vértices que representa la trayectoria.
     * @return String la cadena del codigo xml necesario para cumplir el objetivo.
     */
    public String generaScalableVectorGraphics(Lista<VerticeGrafica<T>> l) {
        // Si no hay trayectoria, simplemente dibujo la gráfica
        if(l.getLongitud() == 0)
            return generaScalableVectorGraphics();
        //remover el fin del encabezado para continuar agregando código 
        String svg = generaScalableVectorGraphics().replaceAll("</svg>",""); 
        if(l.getLongitud() == 1) {
            Vertice<T> v = (Vertice<T>)l.eliminaPrimero();
            double yelem = calculaY(v)+6;
            svg += "<circle cx=\""+calculaX(v)+"\" cy=\""+calculaY(v)+"\" r=\"23\" stroke=\"blue\" stroke-width=\"1\" fill=\"blue\" />\n";
            svg += "<text fill=\"white\" font-family=\"sans-serif\" font-size=\""+tDeLetra(v.elemento)+"\" x=\""+calculaX(v)+"\" y=\""+yelem+"\"\ntext-anchor=\"middle\">"+cortarElemento(v.elemento)+"</text>\n";
            svg += "\n</svg>";
            return svg;
        }
        
        //Dibujar primero 
        Vertice<T> v = (Vertice<T>)l.eliminaPrimero();
        Vertice<T> vaux = (Vertice<T>)l.getPrimero();
        double yelem = calculaY(v)+6,
               tx = ((calculaX(v)+calculaX(vaux))/2), 
               ty = ((calculaY(v)+calculaY(vaux))/2);
            svg += "<line x1=\""+calculaX(v)+"\" y1=\""+calculaY(v)+"\" x2=\""+calculaX(vaux)+"\" y2=\""+calculaY(vaux)+"\" stroke=\"darkorchid\" stroke-width=\"6\" />\n";
            svg += "<circle cx=\""+calculaX(v)+"\" cy=\""+calculaY(v)+"\" r=\"20\" stroke=\"darkorchid\" stroke-width=\"4\" fill=\"forestgreen\" />\n";
            svg += "<text fill=\"white\" font-family=\"sans-serif\" font-size=\""+tDeLetra(v.elemento)+"\" x=\""+calculaX(v)+"\" y=\""+yelem+"\"\ntext-anchor=\"middle\">"+cortarElemento(v.elemento)+"</text>\n";
            svg += "<text fill=\"red\" font-family=\"sans-serif\" font-size=\""+22+"\" x=\""+tx+"\" y=\""+ty+"\"\ntext-anchor=\"middle\">"+(v.aristas.get(vaux.elemento).peso)+"</text>\n"; //buscaArista(v,vaux.elemento)

        while(l.getLongitud()>1) {
            Vertice<T> v1 = (Vertice<T>)l.eliminaPrimero();
            Vertice<T> v2 = (Vertice<T>)l.getPrimero();
            double yelem1 = calculaY(v1)+6,
                   sx = ((calculaX(v1)+calculaX(v2))/2), 
                   sy = ((calculaY(v1)+calculaY(v2))/2);
            svg += "<line x1=\""+calculaX(v1)+"\" y1=\""+calculaY(v1)+"\" x2=\""+calculaX(v2)+"\" y2=\""+calculaY(v2)+"\" stroke=\"darkorchid\" stroke-width=\"6\" />\n";
            svg += "<circle cx=\""+calculaX(v1)+"\" cy=\""+calculaY(v1)+"\" r=\"20\" stroke=\"darkorchid\" stroke-width=\"3\" fill=\"darkorchid\" />\n";
            svg += "<text fill=\"white\" font-family=\"sans-serif\" font-size=\""+tDeLetra(v1.elemento)+"\" x=\""+calculaX(v1)+"\" y=\""+yelem1+"\"\ntext-anchor=\"middle\">"+cortarElemento(v1.elemento)+"</text>\n";
            svg += "<text fill=\"red\" font-family=\"sans-serif\" font-size=\""+22+"\" x=\""+sx+"\" y=\""+sy+"\"\ntext-anchor=\"middle\">"+(v1.aristas.get(v2.elemento).peso)+"</text>\n";//buscaArista(v1,v2.elemento)
        }

        //Dibujar ultimo
        Vertice<T> vf = (Vertice<T>)l.eliminaUltimo();
        double yelemf = calculaY(vf)+6;
        svg +="<circle cx=\""+calculaX(vf)+"\" cy=\""+calculaY(vf)+"\" r=\"20\" stroke=\"darkorchid\" stroke-width=\"4\" fill=\"gold\" />\n";
        svg +="<text fill=\"white\" font-family=\"sans-serif\" font-size=\""+tDeLetra(vf.elemento)+"\" x=\""+calculaX(vf)+"\" y=\""+yelemf+"\"\ntext-anchor=\"middle\">"+cortarElemento(vf.elemento)+"</text>\n";

        return svg + "\n</svg>";
    }

}
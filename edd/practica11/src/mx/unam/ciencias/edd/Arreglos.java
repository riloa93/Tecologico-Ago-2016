package mx.unam.ciencias.edd;

import java.util.Random;

/**
 * Clase para manipular arreglos genéricos.
 */
public class Arreglos {

    /**
     * Ordena el arreglo recibido usando QuickSort.
     * @param a un arreglo cuyos elementos son comparables.
     */
    public static <T extends Comparable<T>>
                     void quickSort(T[] a) {
        quickSort(a,0,a.length-1);
    }

    private static <T extends Comparable<T>>
                     void quickSort(T[] a, int ini, int fin) {
        if(fin - ini < 1)
            return;
        int i = ini + 1; 
        int j = fin;
        while(i < j) 
            if(a[i].compareTo(a[ini]) > 0
                && a[j].compareTo(a[ini]) <= 0)
                intercambia(a, i++, j--);
            else
                if(a[i].compareTo(a[ini]) <= 0)
                    i++;
                else
                    j--;
                if(a[i].compareTo(a[ini]) > 0)
                    i--;
                intercambia(a,i,ini);
                quickSort(a,ini,i-1);
                quickSort(a,i+1,fin);
    }

    private static <T extends Comparable<T>>
                      void intercambia(T[] a, int p, int q) { 
        if(p == q)
            return;
        T w = a[p];
        a[p] = a[q];
        a[q] = w;
    }


    /**
     * Ordena el arreglo recibido usando InsertionSort.
     * @param a un arreglo cuyos elementos son comparables.
     */
    public static <T extends Comparable<T>>
                     void insertionSort(T[] a) {
        int i,j;
        T aux;
        for(i = 0; i < a.length; i++) {
            j = i;
            aux = a[i];
            while(j > 0 && aux.compareTo(a[j-1]) < 0){
                a[j] = a[j-1];
                j--;
            }
            a[j] = aux;
        }
    }

    /**
     * Hace una búsqueda binaria del elemento en el arreglo. Regresa
     * el índice del elemento en el arreglo, o -1 si no se
     * encuentra.
     * @param a el arreglo dónde buscar.
     * @param e el elemento a buscar.
     * @return el índice del elemento en el arreglo, o -1 si no se
     * encuentra.
     */
    public static <T extends Comparable<T>>
                     int busquedaBinaria(T[] a, T e) {
        return busquedaBinaria(a,e,0,a.length-1);
    }

    private static <T extends Comparable<T>>
                     int busquedaBinaria(T[] a, T e, int ini, int fin) {
        if(fin - ini < 0)
            return -1;
        int m = (fin + ini)/2;
        if(e.compareTo(a[m]) == 0)
            return m;
        if(e.compareTo(a[m]) < 0)
            return busquedaBinaria(a,e,ini,m-1);
        return busquedaBinaria(a,e,m+1,fin);
    }

}

package mx.unam.ciencias.edd;

import java.util.Random;
import java.text.NumberFormat;

import java.util.NoSuchElementException;

/**
 * Práctica 11: Diccionarios.
 */
public class Practica11 {

    public static void main(String[] args) {
        int total = (int)(Math.random() * 100);
        Grafica<Integer> grafica = new Grafica<Integer>();
        Grafica<Integer> g = new Grafica<>();
      
        for(int i = 0; i < total ; i++) {
            grafica.agrega(i);
        }

        int ini = 1;
        int fin = 0;
        for(int i = 0; i < total; i++) {
            int a = (int)(Math.random() * total+1);
            int b = (int)(Math.random() * total+1);
            int c = 1 + (int)(Math.random() * 7);
            try {
                grafica.conecta(a,b,c);
                ini = b;
                fin = a;
            } catch (Exception nsee) {}
        }

        g.agrega(1);
        g.agrega(2);
        g.agrega(3);
        g.agrega(4);
        g.agrega(5);
        g.agrega(6);
        g.conecta(1, 2, 22);
        g.conecta(1, 3, 233);
        g.conecta(2, 3, 222);
        g.conecta(2, 4, 355);
        g.conecta(2, 5, 9);
        g.conecta(3, 5,343);
        g.conecta(4, 5, 78);
        g.conecta(4, 6, 55);
        g.conecta(5, 6, 111);

        Lista<VerticeGrafica<Integer>> dijkstra = g.dijkstra(1,4);
        //System.out.println(grafica.generaScalableVectorGraphics());
        System.out.println(g.generaScalableVectorGraphics(dijkstra));

    }
}

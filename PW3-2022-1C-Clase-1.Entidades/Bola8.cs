using System;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class Bola8
    {
        public static string PedirRespuestas(string pregunta)
        {
            Random random = new Random();



            string[] respuestas = {
                                "Es cierto.",
                                "Es decididamente así.",
                                "Sin lugar a dudas.",
                                "Sí, definitivamente.",
                                "Puedes confiar en ello.",
                                "Como yo lo veo, sí.",
                                "Lo más probable.",
                                "Perspectiva buena.",
                                "Sí.",
                                "Las señales apuntan a que sí.",
                                "Respuesta confusa, vuelve a intentarlo.",
                                "Vuelve a preguntar más tarde.",
                                "Mejor no decirte ahora.",
                                "No se puede predecir ahora.",
                                "Concéntrate y vuelve a preguntar.",
                                "No cuentes con ello.",
                                "Mi respuesta es no.",
                                "Mis fuentes dicen que no.",
                                "Las perspectivas no son muy buenas.",
                                "Muy dudoso."
                                };

            int respRandom = random.Next(respuestas.Length + 1);

            return respuestas[respRandom];
        }
    }
}

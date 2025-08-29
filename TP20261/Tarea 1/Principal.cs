

        // Instanciar una Lampara y un Ventilador
        Lampara lampara = new Lampara("Lampara de escritorio", 80, 5);
        Ventilador ventilador = new Ventilador("Ventilador de pie", 120, 3);

        // Encender ambos dispositivos
        lampara.Encender();
        ventilador.Encender();

        // Ajustar consumo
        lampara.AjustarConsumo(); // por defecto: 100 Watts
        ventilador.AjustarConsumo(150); // valor específico

        // Mostrar información
        lampara.MostrarInfo();
        ventilador.MostrarInfo();

        // Comparar consumos
        if (lampara > ventilador)
            Console.WriteLine("La lámpara consume más que el ventilador.");
        else if (lampara == ventilador)
            Console.WriteLine("La lámpara y el ventilador consumen lo mismo.");
        else
            Console.WriteLine("El ventilador consume más que la lámpara.");
  
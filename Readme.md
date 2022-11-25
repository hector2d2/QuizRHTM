Dudas:
    Android 
        - Al seleccionar una respuesta, no se actualiza en la pantalla, se actualiza cuando avanzas a otra pregunta y regresas, 
        una posible solucion es volver asignar las respuestas para que se actualice correctamente:
        CurrentReplies = new ObservableCollection<ReplyModel>(CurrentReplies.ToList());

    Windows
        - Al regresar de una pregunta, el objecto de las respuestas se reinicia, las respuestas seleccionadas no se guardan. Aun 
        no tengo solucion.
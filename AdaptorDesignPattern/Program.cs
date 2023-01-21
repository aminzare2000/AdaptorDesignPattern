global using System;
global using System.Collections.Generic;
global using System.Collections.ObjectModel;
using AdaptorDesignPattern;

List<VectorObject> vectorObjects = new List<VectorObject>
    {
      new VectorRectangle(1, 1, 10, 10),
      new VectorRectangle(3, 3, 6, 6)
    };

Draw();
Draw();



void DrawPoint(Point p)
{
    Console.Write(".");
}


void Draw()
{
    foreach (var vo in vectorObjects)
    {
        foreach (var line in vo)
        {
            var adapter = new LineToPointAdapter(line);
            adapter.ToList().ForEach(DrawPoint);
        }
    }
}
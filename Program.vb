Imports System

Module Program1
    Sub main()
        Console.WriteLine("¿Cuál es tu nombre?" + vbCrLf + "")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("" + vbCrLf + $"Hola {nombre}, acontinuación haremos unos calculos matemáticos" + vbCrLf + "Elije una opción" + vbCrLf + "")
        Dim salir = True
        While salir = True
            Console.WriteLine("" + vbCrLf + "1. Sumar dos números." + vbCrLf + "2. Dividir dos números." + vbCrLf + "3. Multiplicar dos números." + vbCrLf + "4. Restar dos números." + vbCrLf + "")
            Dim opcion As Integer = Console.ReadLine()
            If opcion = 1 Then
                '--------------- SUMA --------------
                Console.WriteLine("" + vbCrLf + "Ingrese dos números a sumar" + vbCrLf + "" + vbCrLf + "Ingrese el primer número: ")
                Dim num1 As Double = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo número: ")
                Dim num2 As Double = Console.ReadLine()
                Dim total As Double = calsuma(num1, num2)
                Console.WriteLine("El resultado de la suma es : " & total)
                Console.WriteLine("" + vbCrLf + "¿Desea realizar otra operación?, Escriba <Y> si desea continuar, de lo contrario escibra <N>")
                Dim bu2 As String = "seguir"
                While bu2 = "seguir"
                    Dim desicion As String = Console.ReadLine()
                    If desicion = "n" Or desicion = "N" Then
                        salir = False
                        bu2 = "noseguir"
                    ElseIf desicion = "y" Or desicion = "Y" Then
                        bu2 = "noseguir"
                        Continue While
                    Else
                        Console.WriteLine("" + vbCrLf + "Opción invalida. Escriba <Y> si desea continuar, de lo contrario escibra <N>" + vbCrLf + "")
                        bu2 = "seguir"
                    End If
                End While
            ElseIf opcion = 2 Then
                '----------------- DIVIDIR ---------------------
                Console.WriteLine("Ingrese dos números a dividir" + vbCrLf + "" + vbCrLf + "Ingrese el primer número: ")
                Dim numd As Double = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo número: ")
                Dim numd2 As Double = Console.ReadLine()
                Dim totald As Double = caldividir(numd, numd2)
                Console.WriteLine("El resultado de la división es:" & totald)
                Console.WriteLine("" + vbCrLf + "¿Desea realizar otra operación?, Escriba <Y> si desea continuar, de lo contrario escibra <N>")
                Dim bu3 As String = "seguir"
                While bu3 = "seguir"
                    Dim desicion2 As String = Console.ReadLine()
                    If desicion2 = "n" Or desicion2 = "N" Then
                        salir = False
                        bu3 = "noseguir"
                    ElseIf desicion2 = "y" Or desicion2 = "Y" Then
                        bu3 = "noseguir"
                        Continue While
                    Else
                        Console.WriteLine("" + vbCrLf + "Opción invalida. Escriba <Y> si desea continuar, de lo contrario escibra <N>" + vbCrLf + "")
                        bu3 = "seguir"
                    End If
                End While
            ElseIf opcion = 3 Then
                '------------------ MULTIPLICACION ---------
                Console.WriteLine("Ingrese dos números a multiplicar" + vbCrLf + "" + vbCrLf + "Ingrese el primer número: ")
                Dim numm As Double = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo número: ")
                Dim numm2 As Double = Console.ReadLine()
                Dim totalm As Double = calmulti(numm, numm2)
                Console.WriteLine("El resultado de la multiplicación es: " & totalm)
                Console.WriteLine("" + vbCrLf + "¿Desea realizar otra operación?, Escriba <Y> si desea continuar, de lo contrario escibra <N>")
                Dim bu4 As String = "seguir"
                While bu4 = "seguir"
                    Dim desicion3 As String = Console.ReadLine()
                    If desicion3 = "n" Or desicion3 = "N" Then
                        salir = False
                        bu4 = "noseguir"
                    ElseIf desicion3 = "y" Or desicion3 = "Y" Then
                        bu4 = "noseguir"
                        Continue While
                    Else
                        Console.WriteLine("" + vbCrLf + "Opción invalida. Escriba <Y> si desea continuar, de lo contrario escibra <N>" + vbCrLf + "")
                        bu4 = "seguir"
                    End If
                End While
            ElseIf opcion = 4 Then
                '------------------ RESTA ----------
                Console.WriteLine("Ingrese dos números a restar" + vbCrLf + "" + vbCrLf + "Ingrese el primer número: ")
                Dim numr As Double = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo número: ")
                Dim numr2 As Double = Console.ReadLine()
                Dim totalr As Double = calresta(numr, numr2)
                Console.WriteLine("El resultado de la resta es: " & totalr)
                Console.WriteLine("" + vbCrLf + "¿Desea realizar otra operación?, Escriba <Y> si desea continuar, de lo contrario escibra <N>")
                Dim bu5 As String = "seguir"
                While bu5 = "seguir"
                    Dim desicion4 As String = Console.ReadLine()
                    If desicion4 = "n" Or desicion4 = "N" Then
                        salir = False
                        bu5 = "noseguir"
                    ElseIf desicion4 = "y" Or desicion4 = "Y" Then
                        bu5 = "noseguir"
                        Continue While
                    Else
                        Console.WriteLine("" + vbCrLf + "Opción invalida. Escriba <Y> si desea continuar, de lo contrario escibra <N>" + vbCrLf + "")
                        bu5 = "seguir"
                    End If
                End While
            Else
                Console.WriteLine("Opción no valida." + vbCrLf + "")
                'Console.ReadLine()
            End If
        End While
    End Sub
    ' ---------------- FUNCIÓN DIVIDIR
    Function caldividir(num1 As Double, num2 As Double) As Double
        Dim dividir As Double = num1 / num2
        Return dividir
    End Function
    ' ----------------- FUNCIÓN SUMAR
    Function calsuma(num1 As Double, num2 As Double) As Double
        Dim suma As Double = num1 + num2
        Return suma
    End Function
    ' ------------------ FUNCIÓN RESTA
    Function calresta(num1 As Double, num2 As Double) As Double
        Dim resta As Double = num1 - num2
        Return resta
    End Function
    ' ------------------ FUNCIÓN MULTIPLICACIÓN
    Function calmulti(num1 As Double, num2 As Double) As Double
        Dim multi As Double = num1 * num2
        Return multi
    End Function
End Module

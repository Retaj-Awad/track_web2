Imports System.Data.SqlClient
Imports System.Data


Public Class Fuel_Shipment_Class


    Sub AddFuel(ByVal region_name, ByVal quantity, ByVal plate_number, ByVal station_numbre, ByVal shipment_status, ByVal user_name)
        Dim cmd As New SqlCommand("insert into Fuel_Shipment(region_name,quantity,plate_number,station_numbre, shipment_status, user_name) values (@region_name,@quantity,@plate_number,@station_numbre, @shipment_status,@ user_name)", con)
        cmd.Parameters.AddWithValue("@region_name", region_name)
        cmd.Parameters.AddWithValue("@quantity", quantity)
        cmd.Parameters.AddWithValue("@plate_number", plate_number)
        cmd.Parameters.AddWithValue("@station_numbre", station_numbre)
        cmd.Parameters.AddWithValue("@shipment_status", shipment_status)
        cmd.Parameters.AddWithValue("@user_name", user_name)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class

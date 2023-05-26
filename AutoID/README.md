### Generate DI
compile -d2 .\Opc.Ua.Di.NodeSet2.xml,Opc.Ua.DI,DI -o2 oo

### Generate AutoID
compile -d2 .\Opc.Ua.AutoID.NodeSet2.xml,Opc.Ua.AutoID,AutoID -d2 .\Opc.Ua.Di.NodeSet2.xml,Opc.Ua.DI,DI -o2 oo

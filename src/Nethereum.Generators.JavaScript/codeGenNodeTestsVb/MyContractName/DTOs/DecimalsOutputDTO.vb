Imports System
Imports System.Threading.Tasks
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Namespace StandardToken.MyContractName.DTOs

    <[FunctionOutput]>
    Public Class DecimalsOutputDTO
    
        <[Parameter]("uint8", "", 1)>
        Public Property B As Byte
    
    End Class

End Namespace

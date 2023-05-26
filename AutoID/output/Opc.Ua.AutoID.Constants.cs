/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;

namespace Opc.Ua.AutoID
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint AutoIdOperationStatusEnumeration = 3013;

        /// <remarks />
        public const uint DeviceStatusEnumeration = 3003;

        /// <remarks />
        public const uint LocationTypeEnumeration = 3009;

        /// <remarks />
        public const uint RfidLockOperationEnumeration = 3016;

        /// <remarks />
        public const uint RfidLockRegionEnumeration = 3015;

        /// <remarks />
        public const uint RfidPasswordTypeEnumeration = 3014;

        /// <remarks />
        public const uint CodeTypeDataType = 3031;

        /// <remarks />
        public const uint LocationName = 3021;

        /// <remarks />
        public const uint NmeaCoordinateString = 3012;

        /// <remarks />
        public const uint AccessResult = 3017;

        /// <remarks />
        public const uint RfidAccessResult = 3018;

        /// <remarks />
        public const uint AntennaNameIdPair = 3011;

        /// <remarks />
        public const uint DhcpGeoConfCoordinate = 3023;

        /// <remarks />
        public const uint LocalCoordinate = 3019;

        /// <remarks />
        public const uint Position = 3004;

        /// <remarks />
        public const uint RfidSighting = 3006;

        /// <remarks />
        public const uint Rotation = 3029;

        /// <remarks />
        public const uint ScanDataEpc = 3024;

        /// <remarks />
        public const uint ScanResult = 3001;

        /// <remarks />
        public const uint OcrScanResult = 3002;

        /// <remarks />
        public const uint OpticalScanResult = 3026;

        /// <remarks />
        public const uint OpticalVerifierScanResult = 3030;

        /// <remarks />
        public const uint RfidScanResult = 3007;

        /// <remarks />
        public const uint RtlsLocationResult = 3028;

        /// <remarks />
        public const uint ScanSettings = 3010;

        /// <remarks />
        public const uint Location = 3008;

        /// <remarks />
        public const uint ScanData = 3020;

        /// <remarks />
        public const uint WGS84Coordinate = 3027;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint AutoIdDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AutoIdDeviceType_GetDeviceLocation = 7042;

        /// <remarks />
        public const uint AutoIdDeviceType_Scan = 7008;

        /// <remarks />
        public const uint AutoIdDeviceType_ScanStart = 7009;

        /// <remarks />
        public const uint AutoIdDeviceType_ScanStop = 7010;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OcrReaderDeviceType_Scan = 7001;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Open = 7019;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Close = 7011;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Read = 7020;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Write = 7022;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_GetPosition = 7012;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_SetPosition = 7021;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Scan = 7043;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Open = 7004;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Close = 7002;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Read = 7005;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Write = 7007;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_GetPosition = 7003;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_SetPosition = 7006;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Scan = 7054;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint RfidReaderDeviceType_Scan = 7013;

        /// <remarks />
        public const uint RfidReaderDeviceType_KillTag = 7017;

        /// <remarks />
        public const uint RfidReaderDeviceType_LockTag = 7018;

        /// <remarks />
        public const uint RfidReaderDeviceType_ReadTag = 7014;

        /// <remarks />
        public const uint RfidReaderDeviceType_SetTagPassword = 7016;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTag = 7015;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTagID = 7023;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint RtlsDeviceType_Scan = 7055;

        /// <remarks />
        public const uint RtlsDeviceType_GetLocation = 7056;

        /// <remarks />
        public const uint RtlsDeviceType_GetSupportedLocationTypes = 7058;

        /// <remarks />
        public const uint RtlsDeviceType_GetUnits = 7057;

        /// <remarks />
        public const string AutoIdDeviceType_GetDeviceLocationMethodType = "";

        /// <remarks />
        public const string AutoIdDeviceType_ScanMethodType = "";

        /// <remarks />
        public const string AutoIdDeviceType_ScanStartMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_CloseMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_GetPositionMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_OpenMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_ReadMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_SetPositionMethodType = "";

        /// <remarks />
        public const string OcrReaderDeviceType_Images_ImageName_WriteMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_KillTagMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_LockTagMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_ReadTagMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_SetTagPasswordMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_WriteTagMethodType = "";

        /// <remarks />
        public const string RfidReaderDeviceType_WriteTagIDMethodType = "";

        /// <remarks />
        public const string RtlsDeviceType_GetLocationMethodType = "";

        /// <remarks />
        public const string RtlsDeviceType_GetSupportedLocationTypesMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics = 5026;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_LastAccess = 5027;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_Logbook = 5032;

        /// <remarks />
        public const uint AutoIdDeviceType_IOData = 5054;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters = 5044;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_ScanSettings = 5033;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint OcrReaderDeviceType_RuntimeParameters = 5043;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images = 5006;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName = 5021;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint OpticalReaderDeviceType_RuntimeParameters = 5045;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images = 5001;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName = 5020;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics = 5038;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess = 5039;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters = 5042;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID_ = 5019;

        /// <remarks />
        public const uint ScanResult_Encoding_DefaultBinary = 5002;

        /// <remarks />
        public const uint ScanResult_Encoding_DefaultXml = 5003;

        /// <remarks />
        public const uint OcrScanResult_Encoding_DefaultBinary = 5004;

        /// <remarks />
        public const uint OcrScanResult_Encoding_DefaultXml = 5005;

        /// <remarks />
        public const uint Position_Encoding_DefaultBinary = 5007;

        /// <remarks />
        public const uint Position_Encoding_DefaultXml = 5008;

        /// <remarks />
        public const uint RfidSighting_Encoding_DefaultBinary = 5009;

        /// <remarks />
        public const uint RfidSighting_Encoding_DefaultXml = 5010;

        /// <remarks />
        public const uint RfidScanResult_Encoding_DefaultBinary = 5011;

        /// <remarks />
        public const uint RfidScanResult_Encoding_DefaultXml = 5012;

        /// <remarks />
        public const uint Location_Encoding_DefaultBinary = 5013;

        /// <remarks />
        public const uint Location_Encoding_DefaultXml = 5014;

        /// <remarks />
        public const uint ScanSettings_Encoding_DefaultBinary = 5015;

        /// <remarks />
        public const uint ScanSettings_Encoding_DefaultXml = 5016;

        /// <remarks />
        public const uint AntennaNameIdPair_Encoding_DefaultBinary = 5017;

        /// <remarks />
        public const uint AntennaNameIdPair_Encoding_DefaultXml = 5018;

        /// <remarks />
        public const uint AccessResult_Encoding_DefaultBinary = 5022;

        /// <remarks />
        public const uint AccessResult_Encoding_DefaultXml = 5023;

        /// <remarks />
        public const uint RfidAccessResult_Encoding_DefaultBinary = 5024;

        /// <remarks />
        public const uint RfidAccessResult_Encoding_DefaultXml = 5025;

        /// <remarks />
        public const uint LocalCoordinate_Encoding_DefaultBinary = 5028;

        /// <remarks />
        public const uint LocalCoordinate_Encoding_DefaultXml = 5029;

        /// <remarks />
        public const uint ScanData_Encoding_DefaultBinary = 5030;

        /// <remarks />
        public const uint ScanData_Encoding_DefaultXml = 5031;

        /// <remarks />
        public const uint DhcpGeoConfCoordinate_Encoding_DefaultBinary = 5034;

        /// <remarks />
        public const uint DhcpGeoConfCoordinate_Encoding_DefaultXml = 5035;

        /// <remarks />
        public const uint ScanDataEpc_Encoding_DefaultBinary = 5036;

        /// <remarks />
        public const uint ScanDataEpc_Encoding_DefaultXml = 5037;

        /// <remarks />
        public const uint OpticalScanResult_Encoding_DefaultBinary = 5040;

        /// <remarks />
        public const uint OpticalScanResult_Encoding_DefaultXml = 5041;

        /// <remarks />
        public const uint WGS84Coordinate_Encoding_DefaultBinary = 5046;

        /// <remarks />
        public const uint WGS84Coordinate_Encoding_DefaultXml = 5047;

        /// <remarks />
        public const uint RtlsLocationResult_Encoding_DefaultBinary = 5048;

        /// <remarks />
        public const uint RtlsLocationResult_Encoding_DefaultXml = 5049;

        /// <remarks />
        public const uint Rotation_Encoding_DefaultBinary = 5050;

        /// <remarks />
        public const uint Rotation_Encoding_DefaultXml = 5051;

        /// <remarks />
        public const uint OpticalVerifierScanResult_Encoding_DefaultBinary = 5052;

        /// <remarks />
        public const uint OpticalVerifierScanResult_Encoding_DefaultXml = 5053;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AutoIdDiagnosticsEventType = 1010;

        /// <remarks />
        public const uint AutoIdAccessEventType = 1015;

        /// <remarks />
        public const uint RfidAccessEventType = 1016;

        /// <remarks />
        public const uint AutoIdLogEntryEventType = 1017;

        /// <remarks />
        public const uint AutoIdPresenceEventType = 1018;

        /// <remarks />
        public const uint AutoIdScanEventType = 1004;

        /// <remarks />
        public const uint OcrScanEventType = 1005;

        /// <remarks />
        public const uint OpticalScanEventType = 1009;

        /// <remarks />
        public const uint OpticalVerifierScanEventType = 1013;

        /// <remarks />
        public const uint RfidScanEventType = 1006;

        /// <remarks />
        public const uint RtlsLocationEventType = 1014;

        /// <remarks />
        public const uint AutoIdDeviceType = 1001;

        /// <remarks />
        public const uint OcrReaderDeviceType = 1002;

        /// <remarks />
        public const uint OpticalReaderDeviceType = 1008;

        /// <remarks />
        public const uint OpticalVerifierDeviceType = 1011;

        /// <remarks />
        public const uint RfidReaderDeviceType = 1003;

        /// <remarks />
        public const uint RtlsDeviceType = 1012;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AutoIdOperationStatusEnumeration_EnumValues = 6201;

        /// <remarks />
        public const uint DeviceStatusEnumeration_EnumStrings = 6029;

        /// <remarks />
        public const uint LocationTypeEnumeration_EnumStrings = 6040;

        /// <remarks />
        public const uint RfidLockOperationEnumeration_EnumStrings = 6067;

        /// <remarks />
        public const uint RfidLockRegionEnumeration_EnumStrings = 6066;

        /// <remarks />
        public const uint RfidPasswordTypeEnumeration_EnumStrings = 6061;

        /// <remarks />
        public const uint AutoID_BinarySchema = 6016;

        /// <remarks />
        public const uint AutoID_XmlSchema = 6018;

        /// <remarks />
        public const uint LocationVariableType_GeographicalUnit = 6199;

        /// <remarks />
        public const uint LocationVariableType_LengthUnit = 6197;

        /// <remarks />
        public const uint LocationVariableType_RotationalUnit = 6198;

        /// <remarks />
        public const uint LocationVariableType_SpeedUnit = 6200;

        /// <remarks />
        public const uint AutoIdDiagnosticsEventType_DeviceName = 6090;

        /// <remarks />
        public const uint AutoIdAccessEventType_AccessResult = 6091;

        /// <remarks />
        public const uint AutoIdAccessEventType_Client = 6092;

        /// <remarks />
        public const uint AutoIdAccessEventType_Command = 6093;

        /// <remarks />
        public const uint RfidAccessEventType_AccessResult = 6094;

        /// <remarks />
        public const uint AutoIdPresenceEventType_Presence = 6095;

        /// <remarks />
        public const uint AutoIdScanEventType_DeviceName = 6049;

        /// <remarks />
        public const uint AutoIdScanEventType_ScanResult = 6024;

        /// <remarks />
        public const uint OcrScanEventType_ScanResult = 6041;

        /// <remarks />
        public const uint OpticalScanEventType_ScanResult = 6147;

        /// <remarks />
        public const uint OpticalVerifierScanEventType_ScanResult = 6227;

        /// <remarks />
        public const uint RfidScanEventType_ScanResult = 6042;

        /// <remarks />
        public const uint RtlsLocationEventType_ScanResult = 6228;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AutoIdDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AutoIdDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AutoIdDeviceType_AutoIdModelVersion = 6193;

        /// <remarks />
        public const uint AutoIdDeviceType_DeviceInfo = 6026;

        /// <remarks />
        public const uint AutoIdDeviceType_DeviceLocation = 6128;

        /// <remarks />
        public const uint AutoIdDeviceType_DeviceLocationName = 6127;

        /// <remarks />
        public const uint AutoIdDeviceType_DeviceName = 6124;

        /// <remarks />
        public const uint AutoIdDeviceType_DeviceStatus = 6030;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_LastAccess_Client = 6103;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_LastAccess_Command = 6104;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_LastAccess_Identifier = 6105;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_LastAccess_Timestamp = 6106;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_Logbook_LastLogEntry = 6102;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_Logbook_LogColumns = 6101;

        /// <remarks />
        public const uint AutoIdDeviceType_Diagnostics_Presence = 6100;

        /// <remarks />
        public const uint AutoIdDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint AutoIdDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint AutoIdDeviceType_LastScanData = 6055;

        /// <remarks />
        public const uint AutoIdDeviceType_LastScanTimestamp = 6096;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_CodeTypes = 6107;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_ScanSettings_CodeType = 6109;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_ScanSettings_Cycles = 6111;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_ScanSettings_DataAvailable = 6110;

        /// <remarks />
        public const uint AutoIdDeviceType_RuntimeParameters_ScanSettings_Duration = 6112;

        /// <remarks />
        public const uint AutoIdDeviceType_Scan_InputArguments = 6050;

        /// <remarks />
        public const uint AutoIdDeviceType_Scan_OutputArguments = 6001;

        /// <remarks />
        public const uint AutoIdDeviceType_ScanActive = 6099;

        /// <remarks />
        public const uint AutoIdDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint AutoIdDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OcrReaderDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OcrReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OcrReaderDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint OcrReaderDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint OcrReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint OcrReaderDeviceType_Scan_InputArguments = 6027;

        /// <remarks />
        public const uint OcrReaderDeviceType_Scan_OutputArguments = 6015;

        /// <remarks />
        public const uint OcrReaderDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint OcrReaderDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Size = 6082;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Writable = 6084;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_UserWritable = 6083;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_OpenCount = 6078;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Open_InputArguments = 6075;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Open_OutputArguments = 6077;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Close_InputArguments = 6072;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Read_InputArguments = 6079;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Read_OutputArguments = 6080;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_Write_InputArguments = 6085;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_GetPosition_InputArguments = 6073;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_GetPosition_OutputArguments = 6074;

        /// <remarks />
        public const uint OcrReaderDeviceType_Images_ImageName_SetPosition_InputArguments = 6081;

        /// <remarks />
        public const uint OcrReaderDeviceType_RuntimeParameters_MatchCode = 6134;

        /// <remarks />
        public const uint OcrReaderDeviceType_RuntimeParameters_TemplateName = 6133;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OpticalReaderDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint OpticalReaderDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint OpticalReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Scan_InputArguments = 6144;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Scan_OutputArguments = 6145;

        /// <remarks />
        public const uint OpticalReaderDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint OpticalReaderDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Size = 6011;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Writable = 6013;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_UserWritable = 6012;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_OpenCount = 6007;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Open_InputArguments = 6005;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Open_OutputArguments = 6006;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Close_InputArguments = 6002;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Read_InputArguments = 6008;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Read_OutputArguments = 6009;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_Write_InputArguments = 6014;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_GetPosition_InputArguments = 6003;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_GetPosition_OutputArguments = 6004;

        /// <remarks />
        public const uint OpticalReaderDeviceType_Images_ImageName_SetPosition_InputArguments = 6010;

        /// <remarks />
        public const uint OpticalReaderDeviceType_RuntimeParameters_MatchCode = 6136;

        /// <remarks />
        public const uint OpticalReaderDeviceType_RuntimeParameters_TemplateName = 6135;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Scan_InputArguments = 6031;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_Scan_OutputArguments = 6076;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint OpticalVerifierDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint RfidReaderDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint RfidReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint RfidReaderDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint RfidReaderDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint RfidReaderDeviceType_Scan_InputArguments = 6052;

        /// <remarks />
        public const uint RfidReaderDeviceType_Scan_OutputArguments = 6043;

        /// <remarks />
        public const uint RfidReaderDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint RfidReaderDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint RfidReaderDeviceType_AntennaNames = 6048;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_Antenna = 6114;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_CurrentPowerLevel = 6115;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_PC = 6116;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_Polarization = 6117;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_RWData = 6113;

        /// <remarks />
        public const uint RfidReaderDeviceType_Diagnostics_LastAccess_Strength = 6118;

        /// <remarks />
        public const uint RfidReaderDeviceType_KillTag_InputArguments = 6062;

        /// <remarks />
        public const uint RfidReaderDeviceType_KillTag_OutputArguments = 6063;

        /// <remarks />
        public const uint RfidReaderDeviceType_LastScanAntenna = 6097;

        /// <remarks />
        public const uint RfidReaderDeviceType_LastScanRSSI = 6098;

        /// <remarks />
        public const uint RfidReaderDeviceType_LockTag_InputArguments = 6064;

        /// <remarks />
        public const uint RfidReaderDeviceType_LockTag_OutputArguments = 6065;

        /// <remarks />
        public const uint RfidReaderDeviceType_ReadTag_InputArguments = 6054;

        /// <remarks />
        public const uint RfidReaderDeviceType_ReadTag_OutputArguments = 6056;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData = 6119;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData_EnumStrings = 6120;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_EnableAntennas = 6126;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_MinRssi = 6146;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_RfPower = 6141;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_TagTypes = 6121;

        /// <remarks />
        public const uint RfidReaderDeviceType_RuntimeParameters_TagTypes_EnumStrings = 6125;

        /// <remarks />
        public const uint RfidReaderDeviceType_SetTagPassword_InputArguments = 6059;

        /// <remarks />
        public const uint RfidReaderDeviceType_SetTagPassword_OutputArguments = 6060;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTag_InputArguments = 6057;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTag_OutputArguments = 6058;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTagID_InputArguments = 6137;

        /// <remarks />
        public const uint RfidReaderDeviceType_WriteTagID_OutputArguments = 6140;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint RtlsDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint RtlsDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint RtlsDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <remarks />
        public const uint RtlsDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <remarks />
        public const uint RtlsDeviceType_RuntimeParameters_CodeTypes_EnumStrings = 6108;

        /// <remarks />
        public const uint RtlsDeviceType_Scan_InputArguments = 6218;

        /// <remarks />
        public const uint RtlsDeviceType_Scan_OutputArguments = 6219;

        /// <remarks />
        public const uint RtlsDeviceType_ScanStart_InputArguments = 6051;

        /// <remarks />
        public const uint RtlsDeviceType_ScanStart_OutputArguments = 6208;

        /// <remarks />
        public const uint RtlsDeviceType_GeographicalUnit = 6214;

        /// <remarks />
        public const uint RtlsDeviceType_GetLocation_InputArguments = 6224;

        /// <remarks />
        public const uint RtlsDeviceType_GetLocation_OutputArguments = 6225;

        /// <remarks />
        public const uint RtlsDeviceType_GetSupportedLocationTypes_OutputArguments = 6226;

        /// <remarks />
        public const uint RtlsDeviceType_LengthUnit = 6217;

        /// <remarks />
        public const uint RtlsDeviceType_RotationalUnit = 6216;

        /// <remarks />
        public const uint RtlsDeviceType_SpeedUnit = 6215;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__NamespaceUri = 6053;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__NamespaceVersion = 6068;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__NamespacePublicationDate = 6039;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__IsNamespaceSubset = 6028;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__StaticNodeIdTypes = 6069;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__StaticNumericNodeIdRange = 6070;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_AutoID__StaticStringNodeIdPattern = 6071;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint LocationVariableType = 2002;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AutoIdOperationStatusEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.AutoIdOperationStatusEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceStatusEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.DeviceStatusEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationTypeEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.LocationTypeEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidLockOperationEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidLockOperationEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidLockRegionEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidLockRegionEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidPasswordTypeEnumeration = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidPasswordTypeEnumeration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId CodeTypeDataType = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.CodeTypeDataType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationName = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.LocationName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId NmeaCoordinateString = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.NmeaCoordinateString, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AccessResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.AccessResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidAccessResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidAccessResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AntennaNameIdPair = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.AntennaNameIdPair, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.DhcpGeoConfCoordinate, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocalCoordinate = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.LocalCoordinate, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Position = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.Position, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidSighting = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidSighting, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Rotation = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.Rotation, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanDataEpc = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.ScanDataEpc, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrScanResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.OcrScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalScanResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.OpticalScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierScanResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.OpticalVerifierScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidScanResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RfidScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsLocationResult = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.RtlsLocationResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanSettings = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.ScanSettings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Location = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.Location, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanData = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.ScanData, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId WGS84Coordinate = new ExpandedNodeId(Opc.Ua.AutoID.DataTypes.WGS84Coordinate, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_GetDeviceLocation, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_ScanStart, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStop = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_ScanStop, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Open = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_Open, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Close = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_Close, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Read = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_Read, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Write = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_Write, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_GetPosition = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_GetPosition, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_SetPosition = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_SetPosition, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Open = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_Open, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Close = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_Close, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Read = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_Read, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Write = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_Write, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_GetPosition = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_GetPosition, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_SetPosition = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalReaderDeviceType_Images_ImageName_SetPosition, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OpticalVerifierDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_KillTag, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_LockTag, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_ReadTag, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_SetTagPassword, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_WriteTag, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTagID = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_WriteTagID, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Scan = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_Scan, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_GetLocation, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetSupportedLocationTypes = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_GetSupportedLocationTypes, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetUnits = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_GetUnits, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocationMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_GetDeviceLocationMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_ScanMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStartMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.AutoIdDeviceType_ScanStartMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_CloseMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_CloseMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_GetPositionMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_GetPositionMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_OpenMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_OpenMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_ReadMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_ReadMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_SetPositionMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_SetPositionMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_WriteMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.OcrReaderDeviceType_Images_ImageName_WriteMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTagMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_KillTagMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTagMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_LockTagMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTagMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_ReadTagMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPasswordMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_SetTagPasswordMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTagMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_WriteTagMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTagIDMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RfidReaderDeviceType_WriteTagIDMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocationMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_GetLocationMethodType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetSupportedLocationTypesMethodType = new ExpandedNodeId(Opc.Ua.AutoID.Methods.RtlsDeviceType_GetSupportedLocationTypesMethodType, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_Diagnostics, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_LastAccess = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_Diagnostics_LastAccess, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_Logbook = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_Diagnostics_Logbook, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_IOData = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_IOData, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_RuntimeParameters, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_ScanSettings = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AutoIdDeviceType_RuntimeParameters_ScanSettings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrReaderDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_RuntimeParameters = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrReaderDeviceType_RuntimeParameters, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrReaderDeviceType_Images, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrReaderDeviceType_Images_ImageName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalReaderDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_RuntimeParameters = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalReaderDeviceType_RuntimeParameters, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalReaderDeviceType_Images, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalReaderDeviceType_Images_ImageName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalVerifierDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidReaderDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidReaderDeviceType_Diagnostics, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidReaderDeviceType_Diagnostics_LastAccess, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidReaderDeviceType_RuntimeParameters, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RtlsDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID_ = new ExpandedNodeId(Opc.Ua.AutoID.Objects.http___opcfoundation_org_UA_AutoID_, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrScanResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrScanResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OcrScanResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Position_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Position_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Position_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Position_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidSighting_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidSighting_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidSighting_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidSighting_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidScanResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidScanResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidScanResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Location_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Location_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Location_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Location_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanSettings_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanSettings_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanSettings_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanSettings_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AntennaNameIdPair_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AntennaNameIdPair_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AntennaNameIdPair_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AntennaNameIdPair_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AccessResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AccessResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AccessResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.AccessResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidAccessResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidAccessResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidAccessResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RfidAccessResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocalCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.LocalCoordinate_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocalCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.LocalCoordinate_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanData_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanData_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanData_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanData_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.DhcpGeoConfCoordinate_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.DhcpGeoConfCoordinate_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanDataEpc_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanDataEpc_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId ScanDataEpc_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.ScanDataEpc_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalScanResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalScanResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalScanResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId WGS84Coordinate_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.WGS84Coordinate_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId WGS84Coordinate_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.WGS84Coordinate_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsLocationResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RtlsLocationResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsLocationResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.RtlsLocationResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Rotation_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Rotation_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId Rotation_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.Rotation_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalVerifierScanResult_Encoding_DefaultBinary, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierScanResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AutoID.Objects.OpticalVerifierScanResult_Encoding_DefaultXml, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDiagnosticsEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdDiagnosticsEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdAccessEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdAccessEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidAccessEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.RfidAccessEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdLogEntryEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdLogEntryEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdPresenceEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdPresenceEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdScanEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdScanEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrScanEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OcrScanEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalScanEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OpticalScanEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierScanEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OpticalVerifierScanEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidScanEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.RfidScanEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsLocationEventType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.RtlsLocationEventType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.AutoIdDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OcrReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OpticalReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.OpticalVerifierDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.RfidReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType = new ExpandedNodeId(Opc.Ua.AutoID.ObjectTypes.RtlsDeviceType, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AutoIdOperationStatusEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdOperationStatusEnumeration_EnumValues, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceStatusEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.DeviceStatusEnumeration_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationTypeEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.LocationTypeEnumeration_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidLockOperationEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidLockOperationEnumeration_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidLockRegionEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidLockRegionEnumeration_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidPasswordTypeEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidPasswordTypeEnumeration_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoID_BinarySchema = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoID_BinarySchema, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoID_XmlSchema = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoID_XmlSchema, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationVariableType_GeographicalUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.LocationVariableType_GeographicalUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationVariableType_LengthUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.LocationVariableType_LengthUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationVariableType_RotationalUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.LocationVariableType_RotationalUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId LocationVariableType_SpeedUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.LocationVariableType_SpeedUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDiagnosticsEventType_DeviceName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDiagnosticsEventType_DeviceName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdAccessEventType_AccessResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdAccessEventType_AccessResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdAccessEventType_Client = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdAccessEventType_Client, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdAccessEventType_Command = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdAccessEventType_Command, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidAccessEventType_AccessResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidAccessEventType_AccessResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdPresenceEventType_Presence = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdPresenceEventType_Presence, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdScanEventType_DeviceName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdScanEventType_DeviceName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdScanEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdScanEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrScanEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrScanEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalScanEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalScanEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierScanEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierScanEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidScanEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidScanEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsLocationEventType_ScanResult = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsLocationEventType_ScanResult, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_AutoIdModelVersion = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_AutoIdModelVersion, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceInfo = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_DeviceInfo, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceLocation = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_DeviceLocation, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceLocationName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_DeviceLocationName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_DeviceName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceStatus = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_DeviceStatus, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_LastAccess_Client = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_LastAccess_Client, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_LastAccess_Command = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_LastAccess_Command, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_LastAccess_Identifier = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_LastAccess_Identifier, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_LastAccess_Timestamp = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_LastAccess_Timestamp, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_Logbook_LastLogEntry = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_Logbook_LastLogEntry, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_Logbook_LogColumns = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_Logbook_LogColumns, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Diagnostics_Presence = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Diagnostics_Presence, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_LastScanData = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_LastScanData, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_LastScanTimestamp = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_LastScanTimestamp, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_CodeTypes = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_CodeTypes, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_ScanSettings_CodeType = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_ScanSettings_CodeType, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_ScanSettings_Cycles = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_ScanSettings_Cycles, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_ScanSettings_DataAvailable = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_ScanSettings_DataAvailable, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters_ScanSettings_Duration = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_RuntimeParameters_ScanSettings_Duration, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanActive = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_ScanActive, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.AutoIdDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Size = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Size, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Writable = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Writable, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_UserWritable = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_UserWritable, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_OpenCount = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_OpenCount, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Open_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Open_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Open_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Close_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Close_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Read_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Read_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Read_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_Write_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_Write_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_GetPosition_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_GetPosition_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images_ImageName_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_Images_ImageName_SetPosition_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_RuntimeParameters_MatchCode = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_RuntimeParameters_MatchCode, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OcrReaderDeviceType_RuntimeParameters_TemplateName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OcrReaderDeviceType_RuntimeParameters_TemplateName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Size = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Size, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Writable = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Writable, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_UserWritable = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_UserWritable, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_OpenCount = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_OpenCount, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Open_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Open_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Open_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Close_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Close_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Read_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Read_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Read_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_Write_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_Write_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_GetPosition_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_GetPosition_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Images_ImageName_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_Images_ImageName_SetPosition_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_RuntimeParameters_MatchCode = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_RuntimeParameters_MatchCode, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalReaderDeviceType_RuntimeParameters_TemplateName = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalReaderDeviceType_RuntimeParameters_TemplateName, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.OpticalVerifierDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_AntennaNames = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_AntennaNames, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_Antenna = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_Antenna, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_CurrentPowerLevel = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_CurrentPowerLevel, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_PC = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_PC, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_Polarization = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_Polarization, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_RWData = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_RWData, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_Diagnostics_LastAccess_Strength = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_Diagnostics_LastAccess_Strength, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_KillTag_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_KillTag_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LastScanAntenna = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_LastScanAntenna, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LastScanRSSI = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_LastScanRSSI, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_LockTag_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_LockTag_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_ReadTag_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_ReadTag_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_CodeTypesRWData_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_EnableAntennas = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_EnableAntennas, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_MinRssi = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_MinRssi, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_RfPower = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_RfPower, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_TagTypes = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_TagTypes, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_RuntimeParameters_TagTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_RuntimeParameters_TagTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_SetTagPassword_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_SetTagPassword_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_WriteTag_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_WriteTag_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTagID_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_WriteTagID_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTagID_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RfidReaderDeviceType_WriteTagID_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GetDeviceLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GetDeviceLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_RuntimeParameters_CodeTypes_EnumStrings = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_RuntimeParameters_CodeTypes_EnumStrings, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Scan_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Scan_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_Scan_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_Scan_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_ScanStart_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_ScanStart_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GeographicalUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GeographicalUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation_InputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GetLocation_InputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GetLocation_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_GetSupportedLocationTypes_OutputArguments = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_GetSupportedLocationTypes_OutputArguments, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_LengthUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_LengthUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_RotationalUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_RotationalUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId RtlsDeviceType_SpeedUnit = new ExpandedNodeId(Opc.Ua.AutoID.Variables.RtlsDeviceType_SpeedUnit, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__NamespaceUri = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__NamespaceUri, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__NamespaceVersion = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__NamespaceVersion, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__NamespacePublicationDate, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__IsNamespaceSubset, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__StaticNodeIdTypes, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__StaticNumericNodeIdRange, Opc.Ua.AutoID.Namespaces.AutoID);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_AutoID__StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.AutoID.Variables.http___opcfoundation_org_UA_AutoID__StaticStringNodeIdPattern, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LocationVariableType = new ExpandedNodeId(Opc.Ua.AutoID.VariableTypes.LocationVariableType, Opc.Ua.AutoID.Namespaces.AutoID);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AccessResult = "AccessResult";

        /// <remarks />
        public const string AntennaNameIdPair = "AntennaNameIdPair";

        /// <remarks />
        public const string AntennaNames = "AntennaNames";

        /// <remarks />
        public const string AutoID_BinarySchema = "AutoID";

        /// <remarks />
        public const string AutoID_XmlSchema = "AutoID";

        /// <remarks />
        public const string AutoIdAccessEventType = "AutoIdAccessEventType";

        /// <remarks />
        public const string AutoIdDeviceType = "AutoIdDeviceType";

        /// <remarks />
        public const string AutoIdDiagnosticsEventType = "AutoIdDiagnosticsEventType";

        /// <remarks />
        public const string AutoIdLogEntryEventType = "AutoIdLogEntryEventType";

        /// <remarks />
        public const string AutoIdModelVersion = "AutoIdModelVersion";

        /// <remarks />
        public const string AutoIdOperationStatusEnumeration = "AutoIdOperationStatusEnumeration";

        /// <remarks />
        public const string AutoIdPresenceEventType = "AutoIdPresenceEventType";

        /// <remarks />
        public const string AutoIdScanEventType = "AutoIdScanEventType";

        /// <remarks />
        public const string Client = "Client";

        /// <remarks />
        public const string CloseMethodType = "CloseMethodType";

        /// <remarks />
        public const string CodeTypeDataType = "CodeTypeDataType";

        /// <remarks />
        public const string Command = "Command";

        /// <remarks />
        public const string DeviceInfo = "DeviceInfo";

        /// <remarks />
        public const string DeviceLocation = "DeviceLocation";

        /// <remarks />
        public const string DeviceLocationName = "DeviceLocationName";

        /// <remarks />
        public const string DeviceName = "DeviceName";

        /// <remarks />
        public const string DeviceStatus = "DeviceStatus";

        /// <remarks />
        public const string DeviceStatusEnumeration = "DeviceStatusEnumeration";

        /// <remarks />
        public const string DhcpGeoConfCoordinate = "DhcpGeoConfCoordinate";

        /// <remarks />
        public const string Diagnostics = "Diagnostics";

        /// <remarks />
        public const string GeographicalUnit = "GeographicalUnit";

        /// <remarks />
        public const string GetDeviceLocation = "GetDeviceLocation";

        /// <remarks />
        public const string GetDeviceLocationMethodType = "GetDeviceLocationMethodType";

        /// <remarks />
        public const string GetLocation = "GetLocation";

        /// <remarks />
        public const string GetLocationMethodType = "GetLocationMethodType";

        /// <remarks />
        public const string GetPositionMethodType = "GetPositionMethodType";

        /// <remarks />
        public const string GetSupportedLocationTypes = "GetSupportedLocationTypes";

        /// <remarks />
        public const string GetSupportedLocationTypesMethodType = "GetSupportedLocationTypesMethodType";

        /// <remarks />
        public const string GetUnits = "GetUnits";

        /// <remarks />
        public const string http___opcfoundation_org_UA_AutoID_ = "http://opcfoundation.org/UA/AutoID/";

        /// <remarks />
        public const string Images = "Images";

        /// <remarks />
        public const string IOData = "IOData";

        /// <remarks />
        public const string KillTag = "KillTag";

        /// <remarks />
        public const string KillTagMethodType = "KillTagMethodType";

        /// <remarks />
        public const string LastScanAntenna = "LastScanAntenna";

        /// <remarks />
        public const string LastScanData = "LastScanData";

        /// <remarks />
        public const string LastScanRSSI = "LastScanRSSI";

        /// <remarks />
        public const string LastScanTimestamp = "LastScanTimestamp";

        /// <remarks />
        public const string LengthUnit = "LengthUnit";

        /// <remarks />
        public const string LocalCoordinate = "LocalCoordinate";

        /// <remarks />
        public const string Location = "Location";

        /// <remarks />
        public const string LocationName = "LocationName";

        /// <remarks />
        public const string LocationTypeEnumeration = "LocationTypeEnumeration";

        /// <remarks />
        public const string LocationVariableType = "LocationVariableType";

        /// <remarks />
        public const string LockTag = "LockTag";

        /// <remarks />
        public const string LockTagMethodType = "LockTagMethodType";

        /// <remarks />
        public const string NmeaCoordinateString = "NmeaCoordinateString";

        /// <remarks />
        public const string OcrReaderDeviceType = "OcrReaderDeviceType";

        /// <remarks />
        public const string OcrScanEventType = "OcrScanEventType";

        /// <remarks />
        public const string OcrScanResult = "OcrScanResult";

        /// <remarks />
        public const string OpenMethodType = "OpenMethodType";

        /// <remarks />
        public const string OpticalReaderDeviceType = "OpticalReaderDeviceType";

        /// <remarks />
        public const string OpticalScanEventType = "OpticalScanEventType";

        /// <remarks />
        public const string OpticalScanResult = "OpticalScanResult";

        /// <remarks />
        public const string OpticalVerifierDeviceType = "OpticalVerifierDeviceType";

        /// <remarks />
        public const string OpticalVerifierScanEventType = "OpticalVerifierScanEventType";

        /// <remarks />
        public const string OpticalVerifierScanResult = "OpticalVerifierScanResult";

        /// <remarks />
        public const string Position = "Position";

        /// <remarks />
        public const string Presence = "Presence";

        /// <remarks />
        public const string ReadMethodType = "ReadMethodType";

        /// <remarks />
        public const string ReadTag = "ReadTag";

        /// <remarks />
        public const string ReadTagMethodType = "ReadTagMethodType";

        /// <remarks />
        public const string RfidAccessEventType = "RfidAccessEventType";

        /// <remarks />
        public const string RfidAccessResult = "RfidAccessResult";

        /// <remarks />
        public const string RfidLockOperationEnumeration = "RfidLockOperationEnumeration";

        /// <remarks />
        public const string RfidLockRegionEnumeration = "RfidLockRegionEnumeration";

        /// <remarks />
        public const string RfidPasswordTypeEnumeration = "RfidPasswordTypeEnumeration";

        /// <remarks />
        public const string RfidReaderDeviceType = "RfidReaderDeviceType";

        /// <remarks />
        public const string RfidScanEventType = "RfidScanEventType";

        /// <remarks />
        public const string RfidScanResult = "RfidScanResult";

        /// <remarks />
        public const string RfidSighting = "RfidSighting";

        /// <remarks />
        public const string Rotation = "Rotation";

        /// <remarks />
        public const string RotationalUnit = "RotationalUnit";

        /// <remarks />
        public const string RtlsDeviceType = "RtlsDeviceType";

        /// <remarks />
        public const string RtlsLocationEventType = "RtlsLocationEventType";

        /// <remarks />
        public const string RtlsLocationResult = "RtlsLocationResult";

        /// <remarks />
        public const string RuntimeParameters = "RuntimeParameters";

        /// <remarks />
        public const string Scan = "Scan";

        /// <remarks />
        public const string ScanActive = "ScanActive";

        /// <remarks />
        public const string ScanData = "ScanData";

        /// <remarks />
        public const string ScanDataEpc = "ScanDataEpc";

        /// <remarks />
        public const string ScanMethodType = "ScanMethodType";

        /// <remarks />
        public const string ScanResult = "ScanResult";

        /// <remarks />
        public const string ScanSettings = "ScanSettings";

        /// <remarks />
        public const string ScanStart = "ScanStart";

        /// <remarks />
        public const string ScanStartMethodType = "ScanStartMethodType";

        /// <remarks />
        public const string ScanStop = "ScanStop";

        /// <remarks />
        public const string SetPositionMethodType = "SetPositionMethodType";

        /// <remarks />
        public const string SetTagPassword = "SetTagPassword";

        /// <remarks />
        public const string SetTagPasswordMethodType = "SetTagPasswordMethodType";

        /// <remarks />
        public const string SpeedUnit = "SpeedUnit";

        /// <remarks />
        public const string WGS84Coordinate = "WGS84Coordinate";

        /// <remarks />
        public const string WriteMethodType = "WriteMethodType";

        /// <remarks />
        public const string WriteTag = "WriteTag";

        /// <remarks />
        public const string WriteTagID = "WriteTagID";

        /// <remarks />
        public const string WriteTagIDMethodType = "WriteTagIDMethodType";

        /// <remarks />
        public const string WriteTagMethodType = "WriteTagMethodType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the AutoID namespace (.NET code namespace is 'Opc.Ua.AutoID').
        /// </summary>
        public const string AutoID = "http://opcfoundation.org/UA/AutoID/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";
    }
    #endregion
}
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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;

namespace Opc.Ua.AutoID
{
    #region AutoIdOperationStatusEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AutoIdOperationStatusEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum AutoIdOperationStatusEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "SUCCESS_0")]
        SUCCESS = 0,

        /// <remarks />
        [EnumMember(Value = "MISC_ERROR_TOTAL_1")]
        MISC_ERROR_TOTAL = 1,

        /// <remarks />
        [EnumMember(Value = "MISC_ERROR_PARTIAL_2")]
        MISC_ERROR_PARTIAL = 2,

        /// <remarks />
        [EnumMember(Value = "PERMISSON_ERROR_3")]
        PERMISSON_ERROR = 3,

        /// <remarks />
        [EnumMember(Value = "PASSWORD_ERROR_4")]
        PASSWORD_ERROR = 4,

        /// <remarks />
        [EnumMember(Value = "REGION_NOT_FOUND_ERROR_5")]
        REGION_NOT_FOUND_ERROR = 5,

        /// <remarks />
        [EnumMember(Value = "OP_NOT_POSSIBLE_ERROR_6")]
        OP_NOT_POSSIBLE_ERROR = 6,

        /// <remarks />
        [EnumMember(Value = "OUT_OF_RANGE_ERROR_7")]
        OUT_OF_RANGE_ERROR = 7,

        /// <remarks />
        [EnumMember(Value = "NO_IDENTIFIER_8")]
        NO_IDENTIFIER = 8,

        /// <remarks />
        [EnumMember(Value = "MULTIPLE_IDENTIFIERS_9")]
        MULTIPLE_IDENTIFIERS = 9,

        /// <remarks />
        [EnumMember(Value = "READ_ERROR_10")]
        READ_ERROR = 10,

        /// <remarks />
        [EnumMember(Value = "DECODING_ERROR_11")]
        DECODING_ERROR = 11,

        /// <remarks />
        [EnumMember(Value = "MATCH_ERROR_12")]
        MATCH_ERROR = 12,

        /// <remarks />
        [EnumMember(Value = "CODE_NOT_SUPPORTED_13")]
        CODE_NOT_SUPPORTED = 13,

        /// <remarks />
        [EnumMember(Value = "WRITE_ERROR_14")]
        WRITE_ERROR = 14,

        /// <remarks />
        [EnumMember(Value = "NOT_SUPPORTED_BY_DEVICE_15")]
        NOT_SUPPORTED_BY_DEVICE = 15,

        /// <remarks />
        [EnumMember(Value = "NOT_SUPPORTED_BY_TAG_16")]
        NOT_SUPPORTED_BY_TAG = 16,

        /// <remarks />
        [EnumMember(Value = "DEVICE_NOT_READY_17")]
        DEVICE_NOT_READY = 17,

        /// <remarks />
        [EnumMember(Value = "INVALID_CONFIGURATION_18")]
        INVALID_CONFIGURATION = 18,

        /// <remarks />
        [EnumMember(Value = "RF_COMMUNICATION_ERROR_19")]
        RF_COMMUNICATION_ERROR = 19,

        /// <remarks />
        [EnumMember(Value = "DEVICE_FAULT_20")]
        DEVICE_FAULT = 20,

        /// <remarks />
        [EnumMember(Value = "TAG_HAS_LOW_BATTERY_21")]
        TAG_HAS_LOW_BATTERY = 21,
    }

    #region AutoIdOperationStatusEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAutoIdOperationStatusEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "AutoIdOperationStatusEnumeration")]
    #if !NET_STANDARD
    public partial class AutoIdOperationStatusEnumerationCollection : List<AutoIdOperationStatusEnumeration>, ICloneable
    #else
    public partial class AutoIdOperationStatusEnumerationCollection : List<AutoIdOperationStatusEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AutoIdOperationStatusEnumerationCollection() {}

        /// <remarks />
        public AutoIdOperationStatusEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AutoIdOperationStatusEnumerationCollection(IEnumerable<AutoIdOperationStatusEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AutoIdOperationStatusEnumerationCollection(AutoIdOperationStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new AutoIdOperationStatusEnumerationCollection(values);
            }

            return new AutoIdOperationStatusEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator AutoIdOperationStatusEnumeration[](AutoIdOperationStatusEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AutoIdOperationStatusEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AutoIdOperationStatusEnumerationCollection clone = new AutoIdOperationStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AutoIdOperationStatusEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DeviceStatusEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_DeviceStatusEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum DeviceStatusEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "Idle_0")]
        Idle = 0,

        /// <remarks />
        [EnumMember(Value = "Error_1")]
        Error = 1,

        /// <remarks />
        [EnumMember(Value = "Scanning_2")]
        Scanning = 2,

        /// <remarks />
        [EnumMember(Value = "Busy_3")]
        Busy = 3,
    }

    #region DeviceStatusEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDeviceStatusEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "DeviceStatusEnumeration")]
    #if !NET_STANDARD
    public partial class DeviceStatusEnumerationCollection : List<DeviceStatusEnumeration>, ICloneable
    #else
    public partial class DeviceStatusEnumerationCollection : List<DeviceStatusEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public DeviceStatusEnumerationCollection() {}

        /// <remarks />
        public DeviceStatusEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public DeviceStatusEnumerationCollection(IEnumerable<DeviceStatusEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator DeviceStatusEnumerationCollection(DeviceStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new DeviceStatusEnumerationCollection(values);
            }

            return new DeviceStatusEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator DeviceStatusEnumeration[](DeviceStatusEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (DeviceStatusEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DeviceStatusEnumerationCollection clone = new DeviceStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeviceStatusEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region LocationTypeEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_LocationTypeEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum LocationTypeEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "NMEA_0")]
        NMEA = 0,

        /// <remarks />
        [EnumMember(Value = "LOCAL_1")]
        LOCAL = 1,

        /// <remarks />
        [EnumMember(Value = "WGS84_2")]
        WGS84 = 2,

        /// <remarks />
        [EnumMember(Value = "NAME_3")]
        NAME = 3,
    }

    #region LocationTypeEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfLocationTypeEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "LocationTypeEnumeration")]
    #if !NET_STANDARD
    public partial class LocationTypeEnumerationCollection : List<LocationTypeEnumeration>, ICloneable
    #else
    public partial class LocationTypeEnumerationCollection : List<LocationTypeEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public LocationTypeEnumerationCollection() {}

        /// <remarks />
        public LocationTypeEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public LocationTypeEnumerationCollection(IEnumerable<LocationTypeEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator LocationTypeEnumerationCollection(LocationTypeEnumeration[] values)
        {
            if (values != null)
            {
                return new LocationTypeEnumerationCollection(values);
            }

            return new LocationTypeEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator LocationTypeEnumeration[](LocationTypeEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (LocationTypeEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LocationTypeEnumerationCollection clone = new LocationTypeEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LocationTypeEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidLockOperationEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_RfidLockOperationEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum RfidLockOperationEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "Lock_0")]
        Lock = 0,

        /// <remarks />
        [EnumMember(Value = "Unlock_1")]
        Unlock = 1,

        /// <remarks />
        [EnumMember(Value = "PermanentLock_2")]
        PermanentLock = 2,

        /// <remarks />
        [EnumMember(Value = "PermanentUnlock_3")]
        PermanentUnlock = 3,
    }

    #region RfidLockOperationEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidLockOperationEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidLockOperationEnumeration")]
    #if !NET_STANDARD
    public partial class RfidLockOperationEnumerationCollection : List<RfidLockOperationEnumeration>, ICloneable
    #else
    public partial class RfidLockOperationEnumerationCollection : List<RfidLockOperationEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidLockOperationEnumerationCollection() {}

        /// <remarks />
        public RfidLockOperationEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidLockOperationEnumerationCollection(IEnumerable<RfidLockOperationEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidLockOperationEnumerationCollection(RfidLockOperationEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidLockOperationEnumerationCollection(values);
            }

            return new RfidLockOperationEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator RfidLockOperationEnumeration[](RfidLockOperationEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidLockOperationEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidLockOperationEnumerationCollection clone = new RfidLockOperationEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidLockOperationEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidLockRegionEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_RfidLockRegionEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum RfidLockRegionEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "Kill_0")]
        Kill = 0,

        /// <remarks />
        [EnumMember(Value = "Access_1")]
        Access = 1,

        /// <remarks />
        [EnumMember(Value = "EPC_2")]
        EPC = 2,

        /// <remarks />
        [EnumMember(Value = "TID_3")]
        TID = 3,

        /// <remarks />
        [EnumMember(Value = "User_4")]
        User = 4,
    }

    #region RfidLockRegionEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidLockRegionEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidLockRegionEnumeration")]
    #if !NET_STANDARD
    public partial class RfidLockRegionEnumerationCollection : List<RfidLockRegionEnumeration>, ICloneable
    #else
    public partial class RfidLockRegionEnumerationCollection : List<RfidLockRegionEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidLockRegionEnumerationCollection() {}

        /// <remarks />
        public RfidLockRegionEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidLockRegionEnumerationCollection(IEnumerable<RfidLockRegionEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidLockRegionEnumerationCollection(RfidLockRegionEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidLockRegionEnumerationCollection(values);
            }

            return new RfidLockRegionEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator RfidLockRegionEnumeration[](RfidLockRegionEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidLockRegionEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidLockRegionEnumerationCollection clone = new RfidLockRegionEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidLockRegionEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidPasswordTypeEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_RfidPasswordTypeEnumeration)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public enum RfidPasswordTypeEnumeration
    {
        /// <remarks />
        [EnumMember(Value = "Access_0")]
        Access = 0,

        /// <remarks />
        [EnumMember(Value = "Kill_1")]
        Kill = 1,

        /// <remarks />
        [EnumMember(Value = "Read_2")]
        Read = 2,

        /// <remarks />
        [EnumMember(Value = "Write_3")]
        Write = 3,
    }

    #region RfidPasswordTypeEnumerationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidPasswordTypeEnumeration", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidPasswordTypeEnumeration")]
    #if !NET_STANDARD
    public partial class RfidPasswordTypeEnumerationCollection : List<RfidPasswordTypeEnumeration>, ICloneable
    #else
    public partial class RfidPasswordTypeEnumerationCollection : List<RfidPasswordTypeEnumeration>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidPasswordTypeEnumerationCollection() {}

        /// <remarks />
        public RfidPasswordTypeEnumerationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidPasswordTypeEnumerationCollection(IEnumerable<RfidPasswordTypeEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidPasswordTypeEnumerationCollection(RfidPasswordTypeEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidPasswordTypeEnumerationCollection(values);
            }

            return new RfidPasswordTypeEnumerationCollection();
        }

        /// <remarks />
        public static explicit operator RfidPasswordTypeEnumeration[](RfidPasswordTypeEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidPasswordTypeEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidPasswordTypeEnumerationCollection clone = new RfidPasswordTypeEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidPasswordTypeEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AccessResult Class
    #if (!OPCUA_EXCLUDE_AccessResult)
    /// <remarks />
    /// <exclude />
    
    public enum AccessResultFields : uint
    {   
        None = 0,
        /// <remarks />
        CodeType = 1,
        /// <remarks />
        Identifier = 2,
        /// <remarks />
        Timestamp = 3
    }
        
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class AccessResult : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AccessResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = AccessResultFields.None;
            m_codeType = null;
            m_identifier = new ScanData();
            m_timestamp = DateTime.MinValue;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public AccessResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "CodeType", IsRequired = false, Order = 1)]
        public string CodeType
        {
            get { return m_codeType;  }
            set { m_codeType = value; }
        }

        /// <remarks />
        [DataMember(Name = "Identifier", IsRequired = false, Order = 2)]
        public ScanData Identifier
        {
            get
            {
                return m_identifier;
            }

            set
            {
                m_identifier = value;

                if (value == null)
                {
                    m_identifier = new ScanData();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 3)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AccessResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AccessResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AccessResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);
            encoder.WriteUInt32(nameof(EncodingMask), (uint)EncodingMask);

            if ((EncodingMask & AccessResultFields.CodeType) != 0) encoder.WriteString("CodeType", CodeType);
            if ((EncodingMask & AccessResultFields.Identifier) != 0) encoder.WriteEncodeable("Identifier", Identifier, typeof(ScanData));
            if ((EncodingMask & AccessResultFields.Timestamp) != 0) encoder.WriteDateTime("Timestamp", Timestamp);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            EncodingMask = (AccessResultFields)decoder.ReadUInt32(nameof(EncodingMask));

            if ((EncodingMask & AccessResultFields.CodeType) != 0) CodeType = decoder.ReadString("CodeType");
            if ((EncodingMask & AccessResultFields.Identifier) != 0) Identifier = (ScanData)decoder.ReadEncodeable("Identifier", typeof(ScanData));
            if ((EncodingMask & AccessResultFields.Timestamp) != 0) Timestamp = decoder.ReadDateTime("Timestamp");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AccessResult value = encodeable as AccessResult;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if ((EncodingMask & AccessResultFields.CodeType) != 0) if (!Utils.IsEqual(m_codeType, value.m_codeType)) return false;
            if ((EncodingMask & AccessResultFields.Identifier) != 0) if (!Utils.IsEqual(m_identifier, value.m_identifier)) return false;
            if ((EncodingMask & AccessResultFields.Timestamp) != 0) if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AccessResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AccessResult clone = (AccessResult)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            if ((EncodingMask & AccessResultFields.CodeType) != 0) clone.m_codeType = (string)Utils.Clone(this.m_codeType);
            if ((EncodingMask & AccessResultFields.Identifier) != 0) clone.m_identifier = (ScanData)Utils.Clone(this.m_identifier);
            if ((EncodingMask & AccessResultFields.Timestamp) != 0) clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_codeType;
        private ScanData m_identifier;
        private DateTime m_timestamp;
        #endregion
    }

    #region AccessResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAccessResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "AccessResult")]
    #if !NET_STANDARD
    public partial class AccessResultCollection : List<AccessResult>, ICloneable
    #else
    public partial class AccessResultCollection : List<AccessResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AccessResultCollection() {}

        /// <remarks />
        public AccessResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AccessResultCollection(IEnumerable<AccessResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AccessResultCollection(AccessResult[] values)
        {
            if (values != null)
            {
                return new AccessResultCollection(values);
            }

            return new AccessResultCollection();
        }

        /// <remarks />
        public static explicit operator AccessResult[](AccessResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AccessResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AccessResultCollection clone = new AccessResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AccessResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidAccessResult Class
    #if (!OPCUA_EXCLUDE_RfidAccessResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum RfidAccessResultFields : uint
    {   
        None = 0,
        /// <remarks />
        CodeTypeRWData = 1,
        /// <remarks />
        RWData = 2,
        /// <remarks />
        Antenna = 3,
        /// <remarks />
        CurrentPowerLevel = 4,
        /// <remarks />
        PC = 5,
        /// <remarks />
        Polarization = 6,
        /// <remarks />
        Strength = 7
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class RfidAccessResult : Opc.Ua.AutoID.AccessResult
    {
        #region Constructors
        /// <remarks />
        public RfidAccessResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_codeTypeRWData = null;
            m_rWData = new ScanData();
            m_antenna = (int)0;
            m_currentPowerLevel = (int)0;
            m_pC = (ushort)0;
            m_polarization = null;
            m_strength = (int)0;
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new RfidAccessResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "CodeTypeRWData", IsRequired = false, Order = 1)]
        public string CodeTypeRWData
        {
            get { return m_codeTypeRWData;  }
            set { m_codeTypeRWData = value; }
        }

        /// <remarks />
        [DataMember(Name = "RWData", IsRequired = false, Order = 2)]
        public ScanData RWData
        {
            get
            {
                return m_rWData;
            }

            set
            {
                m_rWData = value;

                if (value == null)
                {
                    m_rWData = new ScanData();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Antenna", IsRequired = false, Order = 3)]
        public int Antenna
        {
            get { return m_antenna;  }
            set { m_antenna = value; }
        }

        /// <remarks />
        [DataMember(Name = "CurrentPowerLevel", IsRequired = false, Order = 4)]
        public int CurrentPowerLevel
        {
            get { return m_currentPowerLevel;  }
            set { m_currentPowerLevel = value; }
        }

        /// <remarks />
        [DataMember(Name = "PC", IsRequired = false, Order = 5)]
        public ushort PC
        {
            get { return m_pC;  }
            set { m_pC = value; }
        }

        /// <remarks />
        [DataMember(Name = "Polarization", IsRequired = false, Order = 6)]
        public string Polarization
        {
            get { return m_polarization;  }
            set { m_polarization = value; }
        }

        /// <remarks />
        [DataMember(Name = "Strength", IsRequired = false, Order = 7)]
        public int Strength
        {
            get { return m_strength;  }
            set { m_strength = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.RfidAccessResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.RfidAccessResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.RfidAccessResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            if ((EncodingMask & RfidAccessResultFields.CodeTypeRWData) != 0) encoder.WriteString("CodeTypeRWData", CodeTypeRWData);
            if ((EncodingMask & RfidAccessResultFields.RWData) != 0) encoder.WriteEncodeable("RWData", RWData, typeof(ScanData));
            if ((EncodingMask & RfidAccessResultFields.Antenna) != 0) encoder.WriteInt32("Antenna", Antenna);
            if ((EncodingMask & RfidAccessResultFields.CurrentPowerLevel) != 0) encoder.WriteInt32("CurrentPowerLevel", CurrentPowerLevel);
            if ((EncodingMask & RfidAccessResultFields.PC) != 0) encoder.WriteUInt16("PC", PC);
            if ((EncodingMask & RfidAccessResultFields.Polarization) != 0) encoder.WriteString("Polarization", Polarization);
            if ((EncodingMask & RfidAccessResultFields.Strength) != 0) encoder.WriteInt32("Strength", Strength);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            if ((EncodingMask & RfidAccessResultFields.CodeTypeRWData) != 0) CodeTypeRWData = decoder.ReadString("CodeTypeRWData");
            if ((EncodingMask & RfidAccessResultFields.RWData) != 0) RWData = (ScanData)decoder.ReadEncodeable("RWData", typeof(ScanData));
            if ((EncodingMask & RfidAccessResultFields.Antenna) != 0) Antenna = decoder.ReadInt32("Antenna");
            if ((EncodingMask & RfidAccessResultFields.CurrentPowerLevel) != 0) CurrentPowerLevel = decoder.ReadInt32("CurrentPowerLevel");
            if ((EncodingMask & RfidAccessResultFields.PC) != 0) PC = decoder.ReadUInt16("PC");
            if ((EncodingMask & RfidAccessResultFields.Polarization) != 0) Polarization = decoder.ReadString("Polarization");
            if ((EncodingMask & RfidAccessResultFields.Strength) != 0) Strength = decoder.ReadInt32("Strength");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RfidAccessResult value = encodeable as RfidAccessResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if ((EncodingMask & RfidAccessResultFields.CodeTypeRWData) != 0) if (!Utils.IsEqual(m_codeTypeRWData, value.m_codeTypeRWData)) return false;
            if ((EncodingMask & RfidAccessResultFields.RWData) != 0) if (!Utils.IsEqual(m_rWData, value.m_rWData)) return false;
            if ((EncodingMask & RfidAccessResultFields.Antenna) != 0) if (!Utils.IsEqual(m_antenna, value.m_antenna)) return false;
            if ((EncodingMask & RfidAccessResultFields.CurrentPowerLevel) != 0) if (!Utils.IsEqual(m_currentPowerLevel, value.m_currentPowerLevel)) return false;
            if ((EncodingMask & RfidAccessResultFields.PC) != 0) if (!Utils.IsEqual(m_pC, value.m_pC)) return false;
            if ((EncodingMask & RfidAccessResultFields.Polarization) != 0) if (!Utils.IsEqual(m_polarization, value.m_polarization)) return false;
            if ((EncodingMask & RfidAccessResultFields.Strength) != 0) if (!Utils.IsEqual(m_strength, value.m_strength)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (RfidAccessResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidAccessResult clone = (RfidAccessResult)base.MemberwiseClone();

            if ((EncodingMask & RfidAccessResultFields.CodeTypeRWData) != 0) clone.m_codeTypeRWData = (string)Utils.Clone(this.m_codeTypeRWData);
            if ((EncodingMask & RfidAccessResultFields.RWData) != 0) clone.m_rWData = (ScanData)Utils.Clone(this.m_rWData);
            if ((EncodingMask & RfidAccessResultFields.Antenna) != 0) clone.m_antenna = (int)Utils.Clone(this.m_antenna);
            if ((EncodingMask & RfidAccessResultFields.CurrentPowerLevel) != 0) clone.m_currentPowerLevel = (int)Utils.Clone(this.m_currentPowerLevel);
            if ((EncodingMask & RfidAccessResultFields.PC) != 0) clone.m_pC = (ushort)Utils.Clone(this.m_pC);
            if ((EncodingMask & RfidAccessResultFields.Polarization) != 0) clone.m_polarization = (string)Utils.Clone(this.m_polarization);
            if ((EncodingMask & RfidAccessResultFields.Strength) != 0) clone.m_strength = (int)Utils.Clone(this.m_strength);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_codeTypeRWData;
        private ScanData m_rWData;
        private int m_antenna;
        private int m_currentPowerLevel;
        private ushort m_pC;
        private string m_polarization;
        private int m_strength;
        #endregion
    }

    #region RfidAccessResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidAccessResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidAccessResult")]
    #if !NET_STANDARD
    public partial class RfidAccessResultCollection : List<RfidAccessResult>, ICloneable
    #else
    public partial class RfidAccessResultCollection : List<RfidAccessResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidAccessResultCollection() {}

        /// <remarks />
        public RfidAccessResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidAccessResultCollection(IEnumerable<RfidAccessResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidAccessResultCollection(RfidAccessResult[] values)
        {
            if (values != null)
            {
                return new RfidAccessResultCollection(values);
            }

            return new RfidAccessResultCollection();
        }

        /// <remarks />
        public static explicit operator RfidAccessResult[](RfidAccessResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidAccessResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidAccessResultCollection clone = new RfidAccessResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidAccessResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AntennaNameIdPair Class
    #if (!OPCUA_EXCLUDE_AntennaNameIdPair)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class AntennaNameIdPair : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AntennaNameIdPair()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_antennaId = (int)0;
            m_antennaName = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "AntennaId", IsRequired = false, Order = 1)]
        public int AntennaId
        {
            get { return m_antennaId;  }
            set { m_antennaId = value; }
        }

        /// <remarks />
        [DataMember(Name = "AntennaName", IsRequired = false, Order = 2)]
        public string AntennaName
        {
            get { return m_antennaName;  }
            set { m_antennaName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AntennaNameIdPair; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AntennaNameIdPair_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AntennaNameIdPair_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteInt32("AntennaId", AntennaId);
            encoder.WriteString("AntennaName", AntennaName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            AntennaId = decoder.ReadInt32("AntennaId");
            AntennaName = decoder.ReadString("AntennaName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AntennaNameIdPair value = encodeable as AntennaNameIdPair;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_antennaId, value.m_antennaId)) return false;
            if (!Utils.IsEqual(m_antennaName, value.m_antennaName)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AntennaNameIdPair)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AntennaNameIdPair clone = (AntennaNameIdPair)base.MemberwiseClone();

            clone.m_antennaId = (int)Utils.Clone(this.m_antennaId);
            clone.m_antennaName = (string)Utils.Clone(this.m_antennaName);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_antennaId;
        private string m_antennaName;
        #endregion
    }

    #region AntennaNameIdPairCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAntennaNameIdPair", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "AntennaNameIdPair")]
    #if !NET_STANDARD
    public partial class AntennaNameIdPairCollection : List<AntennaNameIdPair>, ICloneable
    #else
    public partial class AntennaNameIdPairCollection : List<AntennaNameIdPair>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AntennaNameIdPairCollection() {}

        /// <remarks />
        public AntennaNameIdPairCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AntennaNameIdPairCollection(IEnumerable<AntennaNameIdPair> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AntennaNameIdPairCollection(AntennaNameIdPair[] values)
        {
            if (values != null)
            {
                return new AntennaNameIdPairCollection(values);
            }

            return new AntennaNameIdPairCollection();
        }

        /// <remarks />
        public static explicit operator AntennaNameIdPair[](AntennaNameIdPairCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AntennaNameIdPairCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AntennaNameIdPairCollection clone = new AntennaNameIdPairCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AntennaNameIdPair)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DhcpGeoConfCoordinate Class
    #if (!OPCUA_EXCLUDE_DhcpGeoConfCoordinate)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class DhcpGeoConfCoordinate : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public DhcpGeoConfCoordinate()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_laRes = (byte)0;
            m_latitudeInteger = (short)0;
            m_latitudeFraction = (int)0;
            m_loRes = (byte)0;
            m_longitudeInteger = (short)0;
            m_longitudeFraction = (int)0;
            m_aT = (byte)0;
            m_altRes = (byte)0;
            m_altitudeInteger = (int)0;
            m_altitudeFraction = (short)0;
            m_datum = (byte)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "LaRes", IsRequired = false, Order = 1)]
        public byte LaRes
        {
            get { return m_laRes;  }
            set { m_laRes = value; }
        }

        /// <remarks />
        [DataMember(Name = "LatitudeInteger", IsRequired = false, Order = 2)]
        public short LatitudeInteger
        {
            get { return m_latitudeInteger;  }
            set { m_latitudeInteger = value; }
        }

        /// <remarks />
        [DataMember(Name = "LatitudeFraction", IsRequired = false, Order = 3)]
        public int LatitudeFraction
        {
            get { return m_latitudeFraction;  }
            set { m_latitudeFraction = value; }
        }

        /// <remarks />
        [DataMember(Name = "LoRes", IsRequired = false, Order = 4)]
        public byte LoRes
        {
            get { return m_loRes;  }
            set { m_loRes = value; }
        }

        /// <remarks />
        [DataMember(Name = "LongitudeInteger", IsRequired = false, Order = 5)]
        public short LongitudeInteger
        {
            get { return m_longitudeInteger;  }
            set { m_longitudeInteger = value; }
        }

        /// <remarks />
        [DataMember(Name = "LongitudeFraction", IsRequired = false, Order = 6)]
        public int LongitudeFraction
        {
            get { return m_longitudeFraction;  }
            set { m_longitudeFraction = value; }
        }

        /// <remarks />
        [DataMember(Name = "AT", IsRequired = false, Order = 7)]
        public byte AT
        {
            get { return m_aT;  }
            set { m_aT = value; }
        }

        /// <remarks />
        [DataMember(Name = "AltRes", IsRequired = false, Order = 8)]
        public byte AltRes
        {
            get { return m_altRes;  }
            set { m_altRes = value; }
        }

        /// <remarks />
        [DataMember(Name = "AltitudeInteger", IsRequired = false, Order = 9)]
        public int AltitudeInteger
        {
            get { return m_altitudeInteger;  }
            set { m_altitudeInteger = value; }
        }

        /// <remarks />
        [DataMember(Name = "AltitudeFraction", IsRequired = false, Order = 10)]
        public short AltitudeFraction
        {
            get { return m_altitudeFraction;  }
            set { m_altitudeFraction = value; }
        }

        /// <remarks />
        [DataMember(Name = "Datum", IsRequired = false, Order = 11)]
        public byte Datum
        {
            get { return m_datum;  }
            set { m_datum = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.DhcpGeoConfCoordinate; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.DhcpGeoConfCoordinate_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.DhcpGeoConfCoordinate_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteByte("LaRes", LaRes);
            encoder.WriteInt16("LatitudeInteger", LatitudeInteger);
            encoder.WriteInt32("LatitudeFraction", LatitudeFraction);
            encoder.WriteByte("LoRes", LoRes);
            encoder.WriteInt16("LongitudeInteger", LongitudeInteger);
            encoder.WriteInt32("LongitudeFraction", LongitudeFraction);
            encoder.WriteByte("AT", AT);
            encoder.WriteByte("AltRes", AltRes);
            encoder.WriteInt32("AltitudeInteger", AltitudeInteger);
            encoder.WriteInt16("AltitudeFraction", AltitudeFraction);
            encoder.WriteByte("Datum", Datum);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            LaRes = decoder.ReadByte("LaRes");
            LatitudeInteger = decoder.ReadInt16("LatitudeInteger");
            LatitudeFraction = decoder.ReadInt32("LatitudeFraction");
            LoRes = decoder.ReadByte("LoRes");
            LongitudeInteger = decoder.ReadInt16("LongitudeInteger");
            LongitudeFraction = decoder.ReadInt32("LongitudeFraction");
            AT = decoder.ReadByte("AT");
            AltRes = decoder.ReadByte("AltRes");
            AltitudeInteger = decoder.ReadInt32("AltitudeInteger");
            AltitudeFraction = decoder.ReadInt16("AltitudeFraction");
            Datum = decoder.ReadByte("Datum");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DhcpGeoConfCoordinate value = encodeable as DhcpGeoConfCoordinate;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_laRes, value.m_laRes)) return false;
            if (!Utils.IsEqual(m_latitudeInteger, value.m_latitudeInteger)) return false;
            if (!Utils.IsEqual(m_latitudeFraction, value.m_latitudeFraction)) return false;
            if (!Utils.IsEqual(m_loRes, value.m_loRes)) return false;
            if (!Utils.IsEqual(m_longitudeInteger, value.m_longitudeInteger)) return false;
            if (!Utils.IsEqual(m_longitudeFraction, value.m_longitudeFraction)) return false;
            if (!Utils.IsEqual(m_aT, value.m_aT)) return false;
            if (!Utils.IsEqual(m_altRes, value.m_altRes)) return false;
            if (!Utils.IsEqual(m_altitudeInteger, value.m_altitudeInteger)) return false;
            if (!Utils.IsEqual(m_altitudeFraction, value.m_altitudeFraction)) return false;
            if (!Utils.IsEqual(m_datum, value.m_datum)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (DhcpGeoConfCoordinate)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DhcpGeoConfCoordinate clone = (DhcpGeoConfCoordinate)base.MemberwiseClone();

            clone.m_laRes = (byte)Utils.Clone(this.m_laRes);
            clone.m_latitudeInteger = (short)Utils.Clone(this.m_latitudeInteger);
            clone.m_latitudeFraction = (int)Utils.Clone(this.m_latitudeFraction);
            clone.m_loRes = (byte)Utils.Clone(this.m_loRes);
            clone.m_longitudeInteger = (short)Utils.Clone(this.m_longitudeInteger);
            clone.m_longitudeFraction = (int)Utils.Clone(this.m_longitudeFraction);
            clone.m_aT = (byte)Utils.Clone(this.m_aT);
            clone.m_altRes = (byte)Utils.Clone(this.m_altRes);
            clone.m_altitudeInteger = (int)Utils.Clone(this.m_altitudeInteger);
            clone.m_altitudeFraction = (short)Utils.Clone(this.m_altitudeFraction);
            clone.m_datum = (byte)Utils.Clone(this.m_datum);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_laRes;
        private short m_latitudeInteger;
        private int m_latitudeFraction;
        private byte m_loRes;
        private short m_longitudeInteger;
        private int m_longitudeFraction;
        private byte m_aT;
        private byte m_altRes;
        private int m_altitudeInteger;
        private short m_altitudeFraction;
        private byte m_datum;
        #endregion
    }

    #region DhcpGeoConfCoordinateCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDhcpGeoConfCoordinate", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "DhcpGeoConfCoordinate")]
    #if !NET_STANDARD
    public partial class DhcpGeoConfCoordinateCollection : List<DhcpGeoConfCoordinate>, ICloneable
    #else
    public partial class DhcpGeoConfCoordinateCollection : List<DhcpGeoConfCoordinate>
    #endif
    {
        #region Constructors
        /// <remarks />
        public DhcpGeoConfCoordinateCollection() {}

        /// <remarks />
        public DhcpGeoConfCoordinateCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public DhcpGeoConfCoordinateCollection(IEnumerable<DhcpGeoConfCoordinate> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator DhcpGeoConfCoordinateCollection(DhcpGeoConfCoordinate[] values)
        {
            if (values != null)
            {
                return new DhcpGeoConfCoordinateCollection(values);
            }

            return new DhcpGeoConfCoordinateCollection();
        }

        /// <remarks />
        public static explicit operator DhcpGeoConfCoordinate[](DhcpGeoConfCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (DhcpGeoConfCoordinateCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DhcpGeoConfCoordinateCollection clone = new DhcpGeoConfCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DhcpGeoConfCoordinate)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region LocalCoordinate Class
    #if (!OPCUA_EXCLUDE_LocalCoordinate)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class LocalCoordinate : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public LocalCoordinate()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_x = (double)0;
            m_y = (double)0;
            m_z = (double)0;
            m_timestamp = DateTime.MinValue;
            m_dilutionOfPrecision = (double)0;
            m_usefulPrecision = (int)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "X", IsRequired = false, Order = 1)]
        public double X
        {
            get { return m_x;  }
            set { m_x = value; }
        }

        /// <remarks />
        [DataMember(Name = "Y", IsRequired = false, Order = 2)]
        public double Y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        /// <remarks />
        [DataMember(Name = "Z", IsRequired = false, Order = 3)]
        public double Z
        {
            get { return m_z;  }
            set { m_z = value; }
        }

        /// <remarks />
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 4)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }

        /// <remarks />
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 5)]
        public double DilutionOfPrecision
        {
            get { return m_dilutionOfPrecision;  }
            set { m_dilutionOfPrecision = value; }
        }

        /// <remarks />
        [DataMember(Name = "UsefulPrecision", IsRequired = false, Order = 6)]
        public int UsefulPrecision
        {
            get { return m_usefulPrecision;  }
            set { m_usefulPrecision = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.LocalCoordinate; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.LocalCoordinate_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.LocalCoordinate_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteDouble("X", X);
            encoder.WriteDouble("Y", Y);
            encoder.WriteDouble("Z", Z);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecision", UsefulPrecision);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            X = decoder.ReadDouble("X");
            Y = decoder.ReadDouble("Y");
            Z = decoder.ReadDouble("Z");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecision = decoder.ReadInt32("UsefulPrecision");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            LocalCoordinate value = encodeable as LocalCoordinate;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;
            if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;
            if (!Utils.IsEqual(m_dilutionOfPrecision, value.m_dilutionOfPrecision)) return false;
            if (!Utils.IsEqual(m_usefulPrecision, value.m_usefulPrecision)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (LocalCoordinate)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LocalCoordinate clone = (LocalCoordinate)base.MemberwiseClone();

            clone.m_x = (double)Utils.Clone(this.m_x);
            clone.m_y = (double)Utils.Clone(this.m_y);
            clone.m_z = (double)Utils.Clone(this.m_z);
            clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);
            clone.m_dilutionOfPrecision = (double)Utils.Clone(this.m_dilutionOfPrecision);
            clone.m_usefulPrecision = (int)Utils.Clone(this.m_usefulPrecision);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_x;
        private double m_y;
        private double m_z;
        private DateTime m_timestamp;
        private double m_dilutionOfPrecision;
        private int m_usefulPrecision;
        #endregion
    }

    #region LocalCoordinateCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfLocalCoordinate", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "LocalCoordinate")]
    #if !NET_STANDARD
    public partial class LocalCoordinateCollection : List<LocalCoordinate>, ICloneable
    #else
    public partial class LocalCoordinateCollection : List<LocalCoordinate>
    #endif
    {
        #region Constructors
        /// <remarks />
        public LocalCoordinateCollection() {}

        /// <remarks />
        public LocalCoordinateCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public LocalCoordinateCollection(IEnumerable<LocalCoordinate> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator LocalCoordinateCollection(LocalCoordinate[] values)
        {
            if (values != null)
            {
                return new LocalCoordinateCollection(values);
            }

            return new LocalCoordinateCollection();
        }

        /// <remarks />
        public static explicit operator LocalCoordinate[](LocalCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (LocalCoordinateCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LocalCoordinateCollection clone = new LocalCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LocalCoordinate)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Position Class
    #if (!OPCUA_EXCLUDE_Position)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class Position : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public Position()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_positionX = (int)0;
            m_positionY = (int)0;
            m_sizeX = (int)0;
            m_sizeY = (int)0;
            m_rotation = (int)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "PositionX", IsRequired = false, Order = 1)]
        public int PositionX
        {
            get { return m_positionX;  }
            set { m_positionX = value; }
        }

        /// <remarks />
        [DataMember(Name = "PositionY", IsRequired = false, Order = 2)]
        public int PositionY
        {
            get { return m_positionY;  }
            set { m_positionY = value; }
        }

        /// <remarks />
        [DataMember(Name = "SizeX", IsRequired = false, Order = 3)]
        public int SizeX
        {
            get { return m_sizeX;  }
            set { m_sizeX = value; }
        }

        /// <remarks />
        [DataMember(Name = "SizeY", IsRequired = false, Order = 4)]
        public int SizeY
        {
            get { return m_sizeY;  }
            set { m_sizeY = value; }
        }

        /// <remarks />
        [DataMember(Name = "Rotation", IsRequired = false, Order = 5)]
        public int Rotation
        {
            get { return m_rotation;  }
            set { m_rotation = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Position; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Position_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Position_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteInt32("PositionX", PositionX);
            encoder.WriteInt32("PositionY", PositionY);
            encoder.WriteInt32("SizeX", SizeX);
            encoder.WriteInt32("SizeY", SizeY);
            encoder.WriteInt32("Rotation", Rotation);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            PositionX = decoder.ReadInt32("PositionX");
            PositionY = decoder.ReadInt32("PositionY");
            SizeX = decoder.ReadInt32("SizeX");
            SizeY = decoder.ReadInt32("SizeY");
            Rotation = decoder.ReadInt32("Rotation");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Position value = encodeable as Position;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_positionX, value.m_positionX)) return false;
            if (!Utils.IsEqual(m_positionY, value.m_positionY)) return false;
            if (!Utils.IsEqual(m_sizeX, value.m_sizeX)) return false;
            if (!Utils.IsEqual(m_sizeY, value.m_sizeY)) return false;
            if (!Utils.IsEqual(m_rotation, value.m_rotation)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Position)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Position clone = (Position)base.MemberwiseClone();

            clone.m_positionX = (int)Utils.Clone(this.m_positionX);
            clone.m_positionY = (int)Utils.Clone(this.m_positionY);
            clone.m_sizeX = (int)Utils.Clone(this.m_sizeX);
            clone.m_sizeY = (int)Utils.Clone(this.m_sizeY);
            clone.m_rotation = (int)Utils.Clone(this.m_rotation);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_positionX;
        private int m_positionY;
        private int m_sizeX;
        private int m_sizeY;
        private int m_rotation;
        #endregion
    }

    #region PositionCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPosition", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "Position")]
    #if !NET_STANDARD
    public partial class PositionCollection : List<Position>, ICloneable
    #else
    public partial class PositionCollection : List<Position>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PositionCollection() {}

        /// <remarks />
        public PositionCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PositionCollection(IEnumerable<Position> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PositionCollection(Position[] values)
        {
            if (values != null)
            {
                return new PositionCollection(values);
            }

            return new PositionCollection();
        }

        /// <remarks />
        public static explicit operator Position[](PositionCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PositionCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PositionCollection clone = new PositionCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Position)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidSighting Class
    #if (!OPCUA_EXCLUDE_RfidSighting)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class RfidSighting : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public RfidSighting()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_antenna = (int)0;
            m_strength = (int)0;
            m_timestamp = DateTime.MinValue;
            m_currentPowerLevel = (int)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Antenna", IsRequired = false, Order = 1)]
        public int Antenna
        {
            get { return m_antenna;  }
            set { m_antenna = value; }
        }

        /// <remarks />
        [DataMember(Name = "Strength", IsRequired = false, Order = 2)]
        public int Strength
        {
            get { return m_strength;  }
            set { m_strength = value; }
        }

        /// <remarks />
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 3)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }

        /// <remarks />
        [DataMember(Name = "CurrentPowerLevel", IsRequired = false, Order = 4)]
        public int CurrentPowerLevel
        {
            get { return m_currentPowerLevel;  }
            set { m_currentPowerLevel = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.RfidSighting; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.RfidSighting_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.RfidSighting_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteInt32("Antenna", Antenna);
            encoder.WriteInt32("Strength", Strength);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteInt32("CurrentPowerLevel", CurrentPowerLevel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            Antenna = decoder.ReadInt32("Antenna");
            Strength = decoder.ReadInt32("Strength");
            Timestamp = decoder.ReadDateTime("Timestamp");
            CurrentPowerLevel = decoder.ReadInt32("CurrentPowerLevel");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RfidSighting value = encodeable as RfidSighting;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_antenna, value.m_antenna)) return false;
            if (!Utils.IsEqual(m_strength, value.m_strength)) return false;
            if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;
            if (!Utils.IsEqual(m_currentPowerLevel, value.m_currentPowerLevel)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (RfidSighting)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidSighting clone = (RfidSighting)base.MemberwiseClone();

            clone.m_antenna = (int)Utils.Clone(this.m_antenna);
            clone.m_strength = (int)Utils.Clone(this.m_strength);
            clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);
            clone.m_currentPowerLevel = (int)Utils.Clone(this.m_currentPowerLevel);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_antenna;
        private int m_strength;
        private DateTime m_timestamp;
        private int m_currentPowerLevel;
        #endregion
    }

    #region RfidSightingCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidSighting", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidSighting")]
    #if !NET_STANDARD
    public partial class RfidSightingCollection : List<RfidSighting>, ICloneable
    #else
    public partial class RfidSightingCollection : List<RfidSighting>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidSightingCollection() {}

        /// <remarks />
        public RfidSightingCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidSightingCollection(IEnumerable<RfidSighting> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidSightingCollection(RfidSighting[] values)
        {
            if (values != null)
            {
                return new RfidSightingCollection(values);
            }

            return new RfidSightingCollection();
        }

        /// <remarks />
        public static explicit operator RfidSighting[](RfidSightingCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidSightingCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidSightingCollection clone = new RfidSightingCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidSighting)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Rotation Class
    #if (!OPCUA_EXCLUDE_Rotation)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class Rotation : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public Rotation()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_yaw = (double)0;
            m_pitch = (double)0;
            m_roll = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Yaw", IsRequired = false, Order = 1)]
        public double Yaw
        {
            get { return m_yaw;  }
            set { m_yaw = value; }
        }

        /// <remarks />
        [DataMember(Name = "Pitch", IsRequired = false, Order = 2)]
        public double Pitch
        {
            get { return m_pitch;  }
            set { m_pitch = value; }
        }

        /// <remarks />
        [DataMember(Name = "Roll", IsRequired = false, Order = 3)]
        public double Roll
        {
            get { return m_roll;  }
            set { m_roll = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Rotation; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Rotation_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Rotation_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteDouble("Yaw", Yaw);
            encoder.WriteDouble("Pitch", Pitch);
            encoder.WriteDouble("Roll", Roll);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            Yaw = decoder.ReadDouble("Yaw");
            Pitch = decoder.ReadDouble("Pitch");
            Roll = decoder.ReadDouble("Roll");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Rotation value = encodeable as Rotation;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_yaw, value.m_yaw)) return false;
            if (!Utils.IsEqual(m_pitch, value.m_pitch)) return false;
            if (!Utils.IsEqual(m_roll, value.m_roll)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Rotation)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Rotation clone = (Rotation)base.MemberwiseClone();

            clone.m_yaw = (double)Utils.Clone(this.m_yaw);
            clone.m_pitch = (double)Utils.Clone(this.m_pitch);
            clone.m_roll = (double)Utils.Clone(this.m_roll);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_yaw;
        private double m_pitch;
        private double m_roll;
        #endregion
    }

    #region RotationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRotation", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "Rotation")]
    #if !NET_STANDARD
    public partial class RotationCollection : List<Rotation>, ICloneable
    #else
    public partial class RotationCollection : List<Rotation>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RotationCollection() {}

        /// <remarks />
        public RotationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RotationCollection(IEnumerable<Rotation> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RotationCollection(Rotation[] values)
        {
            if (values != null)
            {
                return new RotationCollection(values);
            }

            return new RotationCollection();
        }

        /// <remarks />
        public static explicit operator Rotation[](RotationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RotationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RotationCollection clone = new RotationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Rotation)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ScanDataEpc Class
    #if (!OPCUA_EXCLUDE_ScanDataEpc)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class ScanDataEpc : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ScanDataEpc()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_pC = (ushort)0;
            m_uId = null;
            m_xPC_W1 = (ushort)0;
            m_xPC_W2 = (ushort)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "PC", IsRequired = false, Order = 1)]
        public ushort PC
        {
            get { return m_pC;  }
            set { m_pC = value; }
        }

        /// <remarks />
        [DataMember(Name = "UId", IsRequired = false, Order = 2)]
        public byte[] UId
        {
            get { return m_uId;  }
            set { m_uId = value; }
        }

        /// <remarks />
        [DataMember(Name = "XPC_W1", IsRequired = false, Order = 3)]
        public ushort XPC_W1
        {
            get { return m_xPC_W1;  }
            set { m_xPC_W1 = value; }
        }

        /// <remarks />
        [DataMember(Name = "XPC_W2", IsRequired = false, Order = 4)]
        public ushort XPC_W2
        {
            get { return m_xPC_W2;  }
            set { m_xPC_W2 = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ScanDataEpc; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ScanDataEpc_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ScanDataEpc_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteUInt16("PC", PC);
            encoder.WriteByteString("UId", UId);
            encoder.WriteUInt16("XPC_W1", XPC_W1);
            encoder.WriteUInt16("XPC_W2", XPC_W2);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            PC = decoder.ReadUInt16("PC");
            UId = decoder.ReadByteString("UId");
            XPC_W1 = decoder.ReadUInt16("XPC_W1");
            XPC_W2 = decoder.ReadUInt16("XPC_W2");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanDataEpc value = encodeable as ScanDataEpc;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_pC, value.m_pC)) return false;
            if (!Utils.IsEqual(m_uId, value.m_uId)) return false;
            if (!Utils.IsEqual(m_xPC_W1, value.m_xPC_W1)) return false;
            if (!Utils.IsEqual(m_xPC_W2, value.m_xPC_W2)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ScanDataEpc)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanDataEpc clone = (ScanDataEpc)base.MemberwiseClone();

            clone.m_pC = (ushort)Utils.Clone(this.m_pC);
            clone.m_uId = (byte[])Utils.Clone(this.m_uId);
            clone.m_xPC_W1 = (ushort)Utils.Clone(this.m_xPC_W1);
            clone.m_xPC_W2 = (ushort)Utils.Clone(this.m_xPC_W2);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_pC;
        private byte[] m_uId;
        private ushort m_xPC_W1;
        private ushort m_xPC_W2;
        #endregion
    }

    #region ScanDataEpcCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfScanDataEpc", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "ScanDataEpc")]
    #if !NET_STANDARD
    public partial class ScanDataEpcCollection : List<ScanDataEpc>, ICloneable
    #else
    public partial class ScanDataEpcCollection : List<ScanDataEpc>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ScanDataEpcCollection() {}

        /// <remarks />
        public ScanDataEpcCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ScanDataEpcCollection(IEnumerable<ScanDataEpc> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ScanDataEpcCollection(ScanDataEpc[] values)
        {
            if (values != null)
            {
                return new ScanDataEpcCollection(values);
            }

            return new ScanDataEpcCollection();
        }

        /// <remarks />
        public static explicit operator ScanDataEpc[](ScanDataEpcCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ScanDataEpcCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanDataEpcCollection clone = new ScanDataEpcCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanDataEpc)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ScanResult Class
    #if (!OPCUA_EXCLUDE_ScanResult)
    /// <remarks />
    /// <exclude />
    
    public enum ScanResultFields : uint
    {   
        None = 0,
        /// <remarks />
        CodeType = 1,
        /// <remarks />
        ScanData = 2,
        /// <remarks />
        Timestamp = 3,
        /// <remarks />
        Location = 4
    }
        
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class ScanResult : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = ScanResultFields.None;
            m_codeType = null;
            m_scanData = new ScanData();
            m_timestamp = DateTime.MinValue;
            m_location = new Location();
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public ScanResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "CodeType", IsRequired = false, Order = 1)]
        public string CodeType
        {
            get { return m_codeType;  }
            set { m_codeType = value; }
        }

        /// <remarks />
        [DataMember(Name = "ScanData", IsRequired = false, Order = 2)]
        public ScanData ScanData
        {
            get
            {
                return m_scanData;
            }

            set
            {
                m_scanData = value;

                if (value == null)
                {
                    m_scanData = new ScanData();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 3)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }

        /// <remarks />
        [DataMember(Name = "Location", IsRequired = false, Order = 4)]
        public Location Location
        {
            get
            {
                return m_location;
            }

            set
            {
                m_location = value;

                if (value == null)
                {
                    m_location = new Location();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ScanResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ScanResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ScanResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);
            encoder.WriteUInt32(nameof(EncodingMask), (uint)EncodingMask);

            encoder.WriteString("CodeType", CodeType);
            encoder.WriteEncodeable("ScanData", ScanData, typeof(ScanData));
            encoder.WriteDateTime("Timestamp", Timestamp);
            if ((EncodingMask & ScanResultFields.Location) != 0) encoder.WriteEncodeable("Location", Location, typeof(Location));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            EncodingMask = (ScanResultFields)decoder.ReadUInt32(nameof(EncodingMask));

            CodeType = decoder.ReadString("CodeType");
            ScanData = (ScanData)decoder.ReadEncodeable("ScanData", typeof(ScanData));
            Timestamp = decoder.ReadDateTime("Timestamp");
            if ((EncodingMask & ScanResultFields.Location) != 0) Location = (Location)decoder.ReadEncodeable("Location", typeof(Location));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanResult value = encodeable as ScanResult;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if (!Utils.IsEqual(m_codeType, value.m_codeType)) return false;
            if (!Utils.IsEqual(m_scanData, value.m_scanData)) return false;
            if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;
            if ((EncodingMask & ScanResultFields.Location) != 0) if (!Utils.IsEqual(m_location, value.m_location)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ScanResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanResult clone = (ScanResult)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            clone.m_codeType = (string)Utils.Clone(this.m_codeType);
            clone.m_scanData = (ScanData)Utils.Clone(this.m_scanData);
            clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);
            if ((EncodingMask & ScanResultFields.Location) != 0) clone.m_location = (Location)Utils.Clone(this.m_location);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_codeType;
        private ScanData m_scanData;
        private DateTime m_timestamp;
        private Location m_location;
        #endregion
    }

    #region ScanResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfScanResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "ScanResult")]
    #if !NET_STANDARD
    public partial class ScanResultCollection : List<ScanResult>, ICloneable
    #else
    public partial class ScanResultCollection : List<ScanResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ScanResultCollection() {}

        /// <remarks />
        public ScanResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ScanResultCollection(IEnumerable<ScanResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ScanResultCollection(ScanResult[] values)
        {
            if (values != null)
            {
                return new ScanResultCollection(values);
            }

            return new ScanResultCollection();
        }

        /// <remarks />
        public static explicit operator ScanResult[](ScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ScanResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanResultCollection clone = new ScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OcrScanResult Class
    #if (!OPCUA_EXCLUDE_OcrScanResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum OcrScanResultFields : uint
    {   
        None = 0,
        /// <remarks />
        ImageId = 1,
        /// <remarks />
        Quality = 2,
        /// <remarks />
        Position = 3,
        /// <remarks />
        Font = 4,
        /// <remarks />
        DecodingTime = 5
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class OcrScanResult : Opc.Ua.AutoID.ScanResult
    {
        #region Constructors
        /// <remarks />
        public OcrScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_imageId = null;
            m_quality = (byte)0;
            m_position = new Position();
            m_font = null;
            m_decodingTime = DateTime.MinValue;
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new OcrScanResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "ImageId", IsRequired = false, Order = 1)]
        public NodeId ImageId
        {
            get { return m_imageId;  }
            set { m_imageId = value; }
        }

        /// <remarks />
        [DataMember(Name = "Quality", IsRequired = false, Order = 2)]
        public byte Quality
        {
            get { return m_quality;  }
            set { m_quality = value; }
        }

        /// <remarks />
        [DataMember(Name = "Position", IsRequired = false, Order = 3)]
        public Position Position
        {
            get
            {
                return m_position;
            }

            set
            {
                m_position = value;

                if (value == null)
                {
                    m_position = new Position();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Font", IsRequired = false, Order = 4)]
        public string Font
        {
            get { return m_font;  }
            set { m_font = value; }
        }

        /// <remarks />
        [DataMember(Name = "DecodingTime", IsRequired = false, Order = 5)]
        public DateTime DecodingTime
        {
            get { return m_decodingTime;  }
            set { m_decodingTime = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.OcrScanResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.OcrScanResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.OcrScanResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteNodeId("ImageId", ImageId);
            encoder.WriteByte("Quality", Quality);
            encoder.WriteEncodeable("Position", Position, typeof(Position));
            if ((EncodingMask & OcrScanResultFields.Font) != 0) encoder.WriteString("Font", Font);
            if ((EncodingMask & OcrScanResultFields.DecodingTime) != 0) encoder.WriteDateTime("DecodingTime", DecodingTime);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            ImageId = decoder.ReadNodeId("ImageId");
            Quality = decoder.ReadByte("Quality");
            Position = (Position)decoder.ReadEncodeable("Position", typeof(Position));
            if ((EncodingMask & OcrScanResultFields.Font) != 0) Font = decoder.ReadString("Font");
            if ((EncodingMask & OcrScanResultFields.DecodingTime) != 0) DecodingTime = decoder.ReadDateTime("DecodingTime");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OcrScanResult value = encodeable as OcrScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_imageId, value.m_imageId)) return false;
            if (!Utils.IsEqual(m_quality, value.m_quality)) return false;
            if (!Utils.IsEqual(m_position, value.m_position)) return false;
            if ((EncodingMask & OcrScanResultFields.Font) != 0) if (!Utils.IsEqual(m_font, value.m_font)) return false;
            if ((EncodingMask & OcrScanResultFields.DecodingTime) != 0) if (!Utils.IsEqual(m_decodingTime, value.m_decodingTime)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OcrScanResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OcrScanResult clone = (OcrScanResult)base.MemberwiseClone();

            clone.m_imageId = (NodeId)Utils.Clone(this.m_imageId);
            clone.m_quality = (byte)Utils.Clone(this.m_quality);
            clone.m_position = (Position)Utils.Clone(this.m_position);
            if ((EncodingMask & OcrScanResultFields.Font) != 0) clone.m_font = (string)Utils.Clone(this.m_font);
            if ((EncodingMask & OcrScanResultFields.DecodingTime) != 0) clone.m_decodingTime = (DateTime)Utils.Clone(this.m_decodingTime);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_imageId;
        private byte m_quality;
        private Position m_position;
        private string m_font;
        private DateTime m_decodingTime;
        #endregion
    }

    #region OcrScanResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOcrScanResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "OcrScanResult")]
    #if !NET_STANDARD
    public partial class OcrScanResultCollection : List<OcrScanResult>, ICloneable
    #else
    public partial class OcrScanResultCollection : List<OcrScanResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public OcrScanResultCollection() {}

        /// <remarks />
        public OcrScanResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public OcrScanResultCollection(IEnumerable<OcrScanResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator OcrScanResultCollection(OcrScanResult[] values)
        {
            if (values != null)
            {
                return new OcrScanResultCollection(values);
            }

            return new OcrScanResultCollection();
        }

        /// <remarks />
        public static explicit operator OcrScanResult[](OcrScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (OcrScanResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OcrScanResultCollection clone = new OcrScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OcrScanResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OpticalScanResult Class
    #if (!OPCUA_EXCLUDE_OpticalScanResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum OpticalScanResultFields : uint
    {   
        None = 0,
        /// <remarks />
        Grade = 1,
        /// <remarks />
        Position = 2,
        /// <remarks />
        Symbology = 3,
        /// <remarks />
        ImageId = 4
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class OpticalScanResult : Opc.Ua.AutoID.ScanResult
    {
        #region Constructors
        /// <remarks />
        public OpticalScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_grade = (float)0;
            m_position = new Position();
            m_symbology = null;
            m_imageId = null;
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new OpticalScanResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "Grade", IsRequired = false, Order = 1)]
        public float Grade
        {
            get { return m_grade;  }
            set { m_grade = value; }
        }

        /// <remarks />
        [DataMember(Name = "Position", IsRequired = false, Order = 2)]
        public Position Position
        {
            get
            {
                return m_position;
            }

            set
            {
                m_position = value;

                if (value == null)
                {
                    m_position = new Position();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Symbology", IsRequired = false, Order = 3)]
        public string Symbology
        {
            get { return m_symbology;  }
            set { m_symbology = value; }
        }

        /// <remarks />
        [DataMember(Name = "ImageId", IsRequired = false, Order = 4)]
        public NodeId ImageId
        {
            get { return m_imageId;  }
            set { m_imageId = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.OpticalScanResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.OpticalScanResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.OpticalScanResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            if ((EncodingMask & OpticalScanResultFields.Grade) != 0) encoder.WriteFloat("Grade", Grade);
            if ((EncodingMask & OpticalScanResultFields.Position) != 0) encoder.WriteEncodeable("Position", Position, typeof(Position));
            if ((EncodingMask & OpticalScanResultFields.Symbology) != 0) encoder.WriteString("Symbology", Symbology);
            if ((EncodingMask & OpticalScanResultFields.ImageId) != 0) encoder.WriteNodeId("ImageId", ImageId);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            if ((EncodingMask & OpticalScanResultFields.Grade) != 0) Grade = decoder.ReadFloat("Grade");
            if ((EncodingMask & OpticalScanResultFields.Position) != 0) Position = (Position)decoder.ReadEncodeable("Position", typeof(Position));
            if ((EncodingMask & OpticalScanResultFields.Symbology) != 0) Symbology = decoder.ReadString("Symbology");
            if ((EncodingMask & OpticalScanResultFields.ImageId) != 0) ImageId = decoder.ReadNodeId("ImageId");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OpticalScanResult value = encodeable as OpticalScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if ((EncodingMask & OpticalScanResultFields.Grade) != 0) if (!Utils.IsEqual(m_grade, value.m_grade)) return false;
            if ((EncodingMask & OpticalScanResultFields.Position) != 0) if (!Utils.IsEqual(m_position, value.m_position)) return false;
            if ((EncodingMask & OpticalScanResultFields.Symbology) != 0) if (!Utils.IsEqual(m_symbology, value.m_symbology)) return false;
            if ((EncodingMask & OpticalScanResultFields.ImageId) != 0) if (!Utils.IsEqual(m_imageId, value.m_imageId)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OpticalScanResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpticalScanResult clone = (OpticalScanResult)base.MemberwiseClone();

            if ((EncodingMask & OpticalScanResultFields.Grade) != 0) clone.m_grade = (float)Utils.Clone(this.m_grade);
            if ((EncodingMask & OpticalScanResultFields.Position) != 0) clone.m_position = (Position)Utils.Clone(this.m_position);
            if ((EncodingMask & OpticalScanResultFields.Symbology) != 0) clone.m_symbology = (string)Utils.Clone(this.m_symbology);
            if ((EncodingMask & OpticalScanResultFields.ImageId) != 0) clone.m_imageId = (NodeId)Utils.Clone(this.m_imageId);

            return clone;
        }
        #endregion

        #region Private Fields
        private float m_grade;
        private Position m_position;
        private string m_symbology;
        private NodeId m_imageId;
        #endregion
    }

    #region OpticalScanResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOpticalScanResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "OpticalScanResult")]
    #if !NET_STANDARD
    public partial class OpticalScanResultCollection : List<OpticalScanResult>, ICloneable
    #else
    public partial class OpticalScanResultCollection : List<OpticalScanResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public OpticalScanResultCollection() {}

        /// <remarks />
        public OpticalScanResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public OpticalScanResultCollection(IEnumerable<OpticalScanResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator OpticalScanResultCollection(OpticalScanResult[] values)
        {
            if (values != null)
            {
                return new OpticalScanResultCollection(values);
            }

            return new OpticalScanResultCollection();
        }

        /// <remarks />
        public static explicit operator OpticalScanResult[](OpticalScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (OpticalScanResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpticalScanResultCollection clone = new OpticalScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OpticalScanResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OpticalVerifierScanResult Class
    #if (!OPCUA_EXCLUDE_OpticalVerifierScanResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum OpticalVerifierScanResultFields : uint
    {   
        None = 0,
        /// <remarks />
        IsoGrade = 1,
        /// <remarks />
        RMin = 2,
        /// <remarks />
        SymbolContrast = 3,
        /// <remarks />
        ECMin = 4,
        /// <remarks />
        Modulation = 5,
        /// <remarks />
        Defects = 6,
        /// <remarks />
        Decodability = 7,
        /// <remarks />
        Decode_ = 8,
        /// <remarks />
        PrintGain = 9
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class OpticalVerifierScanResult : Opc.Ua.AutoID.OpticalScanResult
    {
        #region Constructors
        /// <remarks />
        public OpticalVerifierScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_isoGrade = null;
            m_rMin = (short)0;
            m_symbolContrast = (short)0;
            m_eCMin = (short)0;
            m_modulation = (short)0;
            m_defects = (short)0;
            m_decodability = (short)0;
            m_decode_ = (short)0;
            m_printGain = (short)0;
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new OpticalVerifierScanResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "IsoGrade", IsRequired = false, Order = 1)]
        public string IsoGrade
        {
            get { return m_isoGrade;  }
            set { m_isoGrade = value; }
        }

        /// <remarks />
        [DataMember(Name = "RMin", IsRequired = false, Order = 2)]
        public short RMin
        {
            get { return m_rMin;  }
            set { m_rMin = value; }
        }

        /// <remarks />
        [DataMember(Name = "SymbolContrast", IsRequired = false, Order = 3)]
        public short SymbolContrast
        {
            get { return m_symbolContrast;  }
            set { m_symbolContrast = value; }
        }

        /// <remarks />
        [DataMember(Name = "ECMin", IsRequired = false, Order = 4)]
        public short ECMin
        {
            get { return m_eCMin;  }
            set { m_eCMin = value; }
        }

        /// <remarks />
        [DataMember(Name = "Modulation", IsRequired = false, Order = 5)]
        public short Modulation
        {
            get { return m_modulation;  }
            set { m_modulation = value; }
        }

        /// <remarks />
        [DataMember(Name = "Defects", IsRequired = false, Order = 6)]
        public short Defects
        {
            get { return m_defects;  }
            set { m_defects = value; }
        }

        /// <remarks />
        [DataMember(Name = "Decodability", IsRequired = false, Order = 7)]
        public short Decodability
        {
            get { return m_decodability;  }
            set { m_decodability = value; }
        }

        /// <remarks />
        [DataMember(Name = "Decode_", IsRequired = false, Order = 8)]
        public short Decode_
        {
            get { return m_decode_;  }
            set { m_decode_ = value; }
        }

        /// <remarks />
        [DataMember(Name = "PrintGain", IsRequired = false, Order = 9)]
        public short PrintGain
        {
            get { return m_printGain;  }
            set { m_printGain = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.OpticalVerifierScanResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.OpticalVerifierScanResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.OpticalVerifierScanResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteString("IsoGrade", IsoGrade);
            encoder.WriteInt16("RMin", RMin);
            encoder.WriteInt16("SymbolContrast", SymbolContrast);
            encoder.WriteInt16("ECMin", ECMin);
            encoder.WriteInt16("Modulation", Modulation);
            encoder.WriteInt16("Defects", Defects);
            encoder.WriteInt16("Decodability", Decodability);
            encoder.WriteInt16("Decode_", Decode_);
            encoder.WriteInt16("PrintGain", PrintGain);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            IsoGrade = decoder.ReadString("IsoGrade");
            RMin = decoder.ReadInt16("RMin");
            SymbolContrast = decoder.ReadInt16("SymbolContrast");
            ECMin = decoder.ReadInt16("ECMin");
            Modulation = decoder.ReadInt16("Modulation");
            Defects = decoder.ReadInt16("Defects");
            Decodability = decoder.ReadInt16("Decodability");
            Decode_ = decoder.ReadInt16("Decode_");
            PrintGain = decoder.ReadInt16("PrintGain");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OpticalVerifierScanResult value = encodeable as OpticalVerifierScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_isoGrade, value.m_isoGrade)) return false;
            if (!Utils.IsEqual(m_rMin, value.m_rMin)) return false;
            if (!Utils.IsEqual(m_symbolContrast, value.m_symbolContrast)) return false;
            if (!Utils.IsEqual(m_eCMin, value.m_eCMin)) return false;
            if (!Utils.IsEqual(m_modulation, value.m_modulation)) return false;
            if (!Utils.IsEqual(m_defects, value.m_defects)) return false;
            if (!Utils.IsEqual(m_decodability, value.m_decodability)) return false;
            if (!Utils.IsEqual(m_decode_, value.m_decode_)) return false;
            if (!Utils.IsEqual(m_printGain, value.m_printGain)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OpticalVerifierScanResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpticalVerifierScanResult clone = (OpticalVerifierScanResult)base.MemberwiseClone();

            clone.m_isoGrade = (string)Utils.Clone(this.m_isoGrade);
            clone.m_rMin = (short)Utils.Clone(this.m_rMin);
            clone.m_symbolContrast = (short)Utils.Clone(this.m_symbolContrast);
            clone.m_eCMin = (short)Utils.Clone(this.m_eCMin);
            clone.m_modulation = (short)Utils.Clone(this.m_modulation);
            clone.m_defects = (short)Utils.Clone(this.m_defects);
            clone.m_decodability = (short)Utils.Clone(this.m_decodability);
            clone.m_decode_ = (short)Utils.Clone(this.m_decode_);
            clone.m_printGain = (short)Utils.Clone(this.m_printGain);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_isoGrade;
        private short m_rMin;
        private short m_symbolContrast;
        private short m_eCMin;
        private short m_modulation;
        private short m_defects;
        private short m_decodability;
        private short m_decode_;
        private short m_printGain;
        #endregion
    }

    #region OpticalVerifierScanResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOpticalVerifierScanResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "OpticalVerifierScanResult")]
    #if !NET_STANDARD
    public partial class OpticalVerifierScanResultCollection : List<OpticalVerifierScanResult>, ICloneable
    #else
    public partial class OpticalVerifierScanResultCollection : List<OpticalVerifierScanResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public OpticalVerifierScanResultCollection() {}

        /// <remarks />
        public OpticalVerifierScanResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public OpticalVerifierScanResultCollection(IEnumerable<OpticalVerifierScanResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator OpticalVerifierScanResultCollection(OpticalVerifierScanResult[] values)
        {
            if (values != null)
            {
                return new OpticalVerifierScanResultCollection(values);
            }

            return new OpticalVerifierScanResultCollection();
        }

        /// <remarks />
        public static explicit operator OpticalVerifierScanResult[](OpticalVerifierScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (OpticalVerifierScanResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpticalVerifierScanResultCollection clone = new OpticalVerifierScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OpticalVerifierScanResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RfidScanResult Class
    #if (!OPCUA_EXCLUDE_RfidScanResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum RfidScanResultFields : uint
    {   
        None = 0,
        /// <remarks />
        Sighting = 1
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class RfidScanResult : Opc.Ua.AutoID.ScanResult
    {
        #region Constructors
        /// <remarks />
        public RfidScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_sighting = new RfidSightingCollection();
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new RfidScanResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "Sighting", IsRequired = false, Order = 1)]
        public RfidSightingCollection Sighting
        {
            get
            {
                return m_sighting;
            }

            set
            {
                m_sighting = value;

                if (value == null)
                {
                    m_sighting = new RfidSightingCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.RfidScanResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.RfidScanResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.RfidScanResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteEncodeableArray("Sighting", Sighting.ToArray(), typeof(RfidSighting));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            Sighting = (RfidSightingCollection)decoder.ReadEncodeableArray("Sighting", typeof(RfidSighting));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RfidScanResult value = encodeable as RfidScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sighting, value.m_sighting)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (RfidScanResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidScanResult clone = (RfidScanResult)base.MemberwiseClone();

            clone.m_sighting = (RfidSightingCollection)Utils.Clone(this.m_sighting);

            return clone;
        }
        #endregion

        #region Private Fields
        private RfidSightingCollection m_sighting;
        #endregion
    }

    #region RfidScanResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRfidScanResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RfidScanResult")]
    #if !NET_STANDARD
    public partial class RfidScanResultCollection : List<RfidScanResult>, ICloneable
    #else
    public partial class RfidScanResultCollection : List<RfidScanResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RfidScanResultCollection() {}

        /// <remarks />
        public RfidScanResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RfidScanResultCollection(IEnumerable<RfidScanResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RfidScanResultCollection(RfidScanResult[] values)
        {
            if (values != null)
            {
                return new RfidScanResultCollection(values);
            }

            return new RfidScanResultCollection();
        }

        /// <remarks />
        public static explicit operator RfidScanResult[](RfidScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RfidScanResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RfidScanResultCollection clone = new RfidScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidScanResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RtlsLocationResult Class
    #if (!OPCUA_EXCLUDE_RtlsLocationResult)
    /// <remarks />
    /// <exclude />
    // NID: Fix AutoId nodeset2 compile
    
    public enum RtlsLocationResultFields : uint
    {   
        None = 0,
        /// <remarks />
        Speed = 1,
        /// <remarks />
        Heading = 2,
        /// <remarks />
        Rotation = 3,
        /// <remarks />
        ReceiveTime = 4
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class RtlsLocationResult : Opc.Ua.AutoID.ScanResult
    {
        #region Constructors
        /// <remarks />
        public RtlsLocationResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_speed = (double)0;
            m_heading = (double)0;
            m_rotation = new Rotation();
            m_receiveTime = DateTime.MinValue;
        }
        #endregion

        #region Public Properties
        // NID: Fix AutoId nodeset2 compile
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public new RtlsLocationResultFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "Speed", IsRequired = false, Order = 1)]
        public double Speed
        {
            get { return m_speed;  }
            set { m_speed = value; }
        }

        /// <remarks />
        [DataMember(Name = "Heading", IsRequired = false, Order = 2)]
        public double Heading
        {
            get { return m_heading;  }
            set { m_heading = value; }
        }

        /// <remarks />
        [DataMember(Name = "Rotation", IsRequired = false, Order = 3)]
        public Rotation Rotation
        {
            get
            {
                return m_rotation;
            }

            set
            {
                m_rotation = value;

                if (value == null)
                {
                    m_rotation = new Rotation();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ReceiveTime", IsRequired = false, Order = 4)]
        public DateTime ReceiveTime
        {
            get { return m_receiveTime;  }
            set { m_receiveTime = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.RtlsLocationResult; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.RtlsLocationResult_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.RtlsLocationResult_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteDouble("Speed", Speed);
            encoder.WriteDouble("Heading", Heading);
            encoder.WriteEncodeable("Rotation", Rotation, typeof(Rotation));
            encoder.WriteDateTime("ReceiveTime", ReceiveTime);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            Speed = decoder.ReadDouble("Speed");
            Heading = decoder.ReadDouble("Heading");
            Rotation = (Rotation)decoder.ReadEncodeable("Rotation", typeof(Rotation));
            ReceiveTime = decoder.ReadDateTime("ReceiveTime");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RtlsLocationResult value = encodeable as RtlsLocationResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_speed, value.m_speed)) return false;
            if (!Utils.IsEqual(m_heading, value.m_heading)) return false;
            if (!Utils.IsEqual(m_rotation, value.m_rotation)) return false;
            if (!Utils.IsEqual(m_receiveTime, value.m_receiveTime)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (RtlsLocationResult)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RtlsLocationResult clone = (RtlsLocationResult)base.MemberwiseClone();

            clone.m_speed = (double)Utils.Clone(this.m_speed);
            clone.m_heading = (double)Utils.Clone(this.m_heading);
            clone.m_rotation = (Rotation)Utils.Clone(this.m_rotation);
            clone.m_receiveTime = (DateTime)Utils.Clone(this.m_receiveTime);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_speed;
        private double m_heading;
        private Rotation m_rotation;
        private DateTime m_receiveTime;
        #endregion
    }

    #region RtlsLocationResultCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRtlsLocationResult", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "RtlsLocationResult")]
    #if !NET_STANDARD
    public partial class RtlsLocationResultCollection : List<RtlsLocationResult>, ICloneable
    #else
    public partial class RtlsLocationResultCollection : List<RtlsLocationResult>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RtlsLocationResultCollection() {}

        /// <remarks />
        public RtlsLocationResultCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RtlsLocationResultCollection(IEnumerable<RtlsLocationResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RtlsLocationResultCollection(RtlsLocationResult[] values)
        {
            if (values != null)
            {
                return new RtlsLocationResultCollection(values);
            }

            return new RtlsLocationResultCollection();
        }

        /// <remarks />
        public static explicit operator RtlsLocationResult[](RtlsLocationResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RtlsLocationResultCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RtlsLocationResultCollection clone = new RtlsLocationResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RtlsLocationResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ScanSettings Class
    #if (!OPCUA_EXCLUDE_ScanSettings)
    /// <remarks />
    /// <exclude />
    
    public enum ScanSettingsFields : uint
    {   
        None = 0,
        /// <remarks />
        Duration = 1,
        /// <remarks />
        Cycles = 2,
        /// <remarks />
        DataAvailable = 3,
        /// <remarks />
        LocationType = 4
    }
        
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class ScanSettings : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ScanSettings()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = ScanSettingsFields.None;
            m_duration = (double)0;
            m_cycles = (int)0;
            m_dataAvailable = true;
            m_locationType = LocationTypeEnumeration.NMEA;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public ScanSettingsFields EncodingMask { get; set; }

        /// <remarks />
        [DataMember(Name = "Duration", IsRequired = false, Order = 1)]
        public double Duration
        {
            get { return m_duration;  }
            set { m_duration = value; }
        }

        /// <remarks />
        [DataMember(Name = "Cycles", IsRequired = false, Order = 2)]
        public int Cycles
        {
            get { return m_cycles;  }
            set { m_cycles = value; }
        }

        /// <remarks />
        [DataMember(Name = "DataAvailable", IsRequired = false, Order = 3)]
        public bool DataAvailable
        {
            get { return m_dataAvailable;  }
            set { m_dataAvailable = value; }
        }

        /// <remarks />
        [DataMember(Name = "LocationType", IsRequired = false, Order = 4)]
        public LocationTypeEnumeration LocationType
        {
            get { return m_locationType;  }
            set { m_locationType = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ScanSettings; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ScanSettings_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ScanSettings_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);
            encoder.WriteUInt32(nameof(EncodingMask), (uint)EncodingMask);

            encoder.WriteDouble("Duration", Duration);
            encoder.WriteInt32("Cycles", Cycles);
            encoder.WriteBoolean("DataAvailable", DataAvailable);
            if ((EncodingMask & ScanSettingsFields.LocationType) != 0) encoder.WriteEnumerated("LocationType", LocationType);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            EncodingMask = (ScanSettingsFields)decoder.ReadUInt32(nameof(EncodingMask));

            Duration = decoder.ReadDouble("Duration");
            Cycles = decoder.ReadInt32("Cycles");
            DataAvailable = decoder.ReadBoolean("DataAvailable");
            if ((EncodingMask & ScanSettingsFields.LocationType) != 0) LocationType = (LocationTypeEnumeration)decoder.ReadEnumerated("LocationType", typeof(LocationTypeEnumeration));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanSettings value = encodeable as ScanSettings;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if (!Utils.IsEqual(m_duration, value.m_duration)) return false;
            if (!Utils.IsEqual(m_cycles, value.m_cycles)) return false;
            if (!Utils.IsEqual(m_dataAvailable, value.m_dataAvailable)) return false;
            if ((EncodingMask & ScanSettingsFields.LocationType) != 0) if (!Utils.IsEqual(m_locationType, value.m_locationType)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ScanSettings)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanSettings clone = (ScanSettings)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            clone.m_duration = (double)Utils.Clone(this.m_duration);
            clone.m_cycles = (int)Utils.Clone(this.m_cycles);
            clone.m_dataAvailable = (bool)Utils.Clone(this.m_dataAvailable);
            if ((EncodingMask & ScanSettingsFields.LocationType) != 0) clone.m_locationType = (LocationTypeEnumeration)Utils.Clone(this.m_locationType);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_duration;
        private int m_cycles;
        private bool m_dataAvailable;
        private LocationTypeEnumeration m_locationType;
        #endregion
    }

    #region ScanSettingsCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfScanSettings", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "ScanSettings")]
    #if !NET_STANDARD
    public partial class ScanSettingsCollection : List<ScanSettings>, ICloneable
    #else
    public partial class ScanSettingsCollection : List<ScanSettings>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ScanSettingsCollection() {}

        /// <remarks />
        public ScanSettingsCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ScanSettingsCollection(IEnumerable<ScanSettings> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ScanSettingsCollection(ScanSettings[] values)
        {
            if (values != null)
            {
                return new ScanSettingsCollection(values);
            }

            return new ScanSettingsCollection();
        }

        /// <remarks />
        public static explicit operator ScanSettings[](ScanSettingsCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ScanSettingsCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanSettingsCollection clone = new ScanSettingsCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanSettings)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region Location Class
    #if (!OPCUA_EXCLUDE_Location)
    /// <remarks />
    /// <exclude />
    public enum LocationFields : uint
    {
        /// <remarks />
        None = 0,
        /// <remarks />
        NMEA = 1,
        /// <remarks />
        Local = 2,
        /// <remarks />
        WGS84 = 3,
        /// <remarks />
        Name = 4
    }

    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class Location : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public Location()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SwitchField = LocationFields.None;
            m_nMEA = null;
            m_local = new LocalCoordinate();
            m_wGS84 = new WGS84Coordinate();
            m_name = null;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public LocationFields SwitchField { get; set; }

        /// <remarks />
        [DataMember(Name = "NMEA", IsRequired = false, Order = 1)]
        public string NMEA
        {
            get { return m_nMEA;  }
            set { m_nMEA = value; }
        }

        /// <remarks />
        [DataMember(Name = "Local", IsRequired = false, Order = 2)]
        public LocalCoordinate Local
        {
            get
            {
                return m_local;
            }

            set
            {
                m_local = value;

                if (value == null)
                {
                    m_local = new LocalCoordinate();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "WGS84", IsRequired = false, Order = 3)]
        public WGS84Coordinate WGS84
        {
            get
            {
                return m_wGS84;
            }

            set
            {
                m_wGS84 = value;

                if (value == null)
                {
                    m_wGS84 = new WGS84Coordinate();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Name", IsRequired = false, Order = 4)]
        public string Name
        {
            get { return m_name;  }
            set { m_name = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Location; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Location_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Location_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);
            encoder.WriteUInt32(nameof(SwitchField), (uint)SwitchField);

            switch (SwitchField)
            {
                default: { break; }
                case LocationFields.NMEA: { encoder.WriteString("NMEA", NMEA); break; }
                case LocationFields.Local: { encoder.WriteEncodeable("Local", Local, typeof(LocalCoordinate)); break; }
                case LocationFields.WGS84: { encoder.WriteEncodeable("WGS84", WGS84, typeof(WGS84Coordinate)); break; }
                case LocationFields.Name: { encoder.WriteString("Name", Name); break; }
            }
            
            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            SwitchField = (LocationFields)decoder.ReadUInt32(nameof(SwitchField));
                
            switch (SwitchField)
            {
                default: { break; }
                case LocationFields.NMEA: { NMEA = decoder.ReadString("NMEA"); break; }
                case LocationFields.Local: { Local = (LocalCoordinate)decoder.ReadEncodeable("Local", typeof(LocalCoordinate)); break; }
                case LocationFields.WGS84: { WGS84 = (WGS84Coordinate)decoder.ReadEncodeable("WGS84", typeof(WGS84Coordinate)); break; }
                case LocationFields.Name: { Name = decoder.ReadString("Name"); break; }
            }

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Location value = encodeable as Location;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case LocationFields.NMEA: { if (!Utils.IsEqual(m_nMEA, value.m_nMEA)) return false; break; }
                case LocationFields.Local: { if (!Utils.IsEqual(m_local, value.m_local)) return false; break; }
                case LocationFields.WGS84: { if (!Utils.IsEqual(m_wGS84, value.m_wGS84)) return false; break; }
                case LocationFields.Name: { if (!Utils.IsEqual(m_name, value.m_name)) return false; break; }
            }

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Location)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Location clone = (Location)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case LocationFields.NMEA: { clone.m_nMEA = (string)Utils.Clone(this.m_nMEA); break; }
                case LocationFields.Local: { clone.m_local = (LocalCoordinate)Utils.Clone(this.m_local); break; }
                case LocationFields.WGS84: { clone.m_wGS84 = (WGS84Coordinate)Utils.Clone(this.m_wGS84); break; }
                case LocationFields.Name: { clone.m_name = (string)Utils.Clone(this.m_name); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_nMEA;
        private LocalCoordinate m_local;
        private WGS84Coordinate m_wGS84;
        private string m_name;
        #endregion
    }

    #region LocationCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfLocation", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "Location")]
    #if !NET_STANDARD
    public partial class LocationCollection : List<Location>, ICloneable
    #else
    public partial class LocationCollection : List<Location>
    #endif
    {
        #region Constructors
        /// <remarks />
        public LocationCollection() {}

        /// <remarks />
        public LocationCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public LocationCollection(IEnumerable<Location> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator LocationCollection(Location[] values)
        {
            if (values != null)
            {
                return new LocationCollection(values);
            }

            return new LocationCollection();
        }

        /// <remarks />
        public static explicit operator Location[](LocationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (LocationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LocationCollection clone = new LocationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Location)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ScanData Class
    #if (!OPCUA_EXCLUDE_ScanData)
    /// <remarks />
    /// <exclude />
    public enum ScanDataFields : uint
    {
        /// <remarks />
        None = 0,
        /// <remarks />
        ByteString = 1,
        /// <remarks />
        String = 2,
        /// <remarks />
        Epc = 3,
        /// <remarks />
        Custom = 4
    }

    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class ScanData : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ScanData()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SwitchField = ScanDataFields.None;
            m_byteString = null;
            m_string = null;
            m_epc = new ScanDataEpc();
            m_custom = Variant.Null;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public ScanDataFields SwitchField { get; set; }

        /// <remarks />
        [DataMember(Name = "ByteString", IsRequired = false, Order = 1)]
        public byte[] ByteString
        {
            get { return m_byteString;  }
            set { m_byteString = value; }
        }

        /// <remarks />
        [DataMember(Name = "String", IsRequired = false, Order = 2)]
        public string String
        {
            get { return m_string;  }
            set { m_string = value; }
        }

        /// <remarks />
        [DataMember(Name = "Epc", IsRequired = false, Order = 3)]
        public ScanDataEpc Epc
        {
            get
            {
                return m_epc;
            }

            set
            {
                m_epc = value;

                if (value == null)
                {
                    m_epc = new ScanDataEpc();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Custom", IsRequired = false, Order = 4)]
        public Variant Custom
        {
            get { return m_custom;  }
            set { m_custom = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ScanData; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ScanData_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ScanData_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);
            encoder.WriteUInt32(nameof(SwitchField), (uint)SwitchField);

            switch (SwitchField)
            {
                default: { break; }
                case ScanDataFields.ByteString: { encoder.WriteByteString("ByteString", ByteString); break; }
                case ScanDataFields.String: { encoder.WriteString("String", String); break; }
                case ScanDataFields.Epc: { encoder.WriteEncodeable("Epc", Epc, typeof(ScanDataEpc)); break; }
                case ScanDataFields.Custom: { encoder.WriteVariant("Custom", Custom); break; }
            }
            
            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            SwitchField = (ScanDataFields)decoder.ReadUInt32(nameof(SwitchField));
                
            switch (SwitchField)
            {
                default: { break; }
                case ScanDataFields.ByteString: { ByteString = decoder.ReadByteString("ByteString"); break; }
                case ScanDataFields.String: { String = decoder.ReadString("String"); break; }
                case ScanDataFields.Epc: { Epc = (ScanDataEpc)decoder.ReadEncodeable("Epc", typeof(ScanDataEpc)); break; }
                case ScanDataFields.Custom: { Custom = decoder.ReadVariant("Custom"); break; }
            }

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanData value = encodeable as ScanData;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case ScanDataFields.ByteString: { if (!Utils.IsEqual(m_byteString, value.m_byteString)) return false; break; }
                case ScanDataFields.String: { if (!Utils.IsEqual(m_string, value.m_string)) return false; break; }
                case ScanDataFields.Epc: { if (!Utils.IsEqual(m_epc, value.m_epc)) return false; break; }
                case ScanDataFields.Custom: { if (!Utils.IsEqual(m_custom, value.m_custom)) return false; break; }
            }

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ScanData)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanData clone = (ScanData)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case ScanDataFields.ByteString: { clone.m_byteString = (byte[])Utils.Clone(this.m_byteString); break; }
                case ScanDataFields.String: { clone.m_string = (string)Utils.Clone(this.m_string); break; }
                case ScanDataFields.Epc: { clone.m_epc = (ScanDataEpc)Utils.Clone(this.m_epc); break; }
                case ScanDataFields.Custom: { clone.m_custom = (Variant)Utils.Clone(this.m_custom); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private byte[] m_byteString;
        private string m_string;
        private ScanDataEpc m_epc;
        private Variant m_custom;
        #endregion
    }

    #region ScanDataCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfScanData", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "ScanData")]
    #if !NET_STANDARD
    public partial class ScanDataCollection : List<ScanData>, ICloneable
    #else
    public partial class ScanDataCollection : List<ScanData>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ScanDataCollection() {}

        /// <remarks />
        public ScanDataCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ScanDataCollection(IEnumerable<ScanData> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ScanDataCollection(ScanData[] values)
        {
            if (values != null)
            {
                return new ScanDataCollection(values);
            }

            return new ScanDataCollection();
        }

        /// <remarks />
        public static explicit operator ScanData[](ScanDataCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ScanDataCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ScanDataCollection clone = new ScanDataCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanData)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region WGS84Coordinate Class
    #if (!OPCUA_EXCLUDE_WGS84Coordinate)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.AutoID.Namespaces.AutoID)]
    public partial class WGS84Coordinate : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public WGS84Coordinate()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_n_S_Hemisphere = null;
            m_latitude = (double)0;
            m_e_W_Hemisphere = null;
            m_longitude = (double)0;
            m_altitude = (double)0;
            m_timestamp = DateTime.MinValue;
            m_dilutionOfPrecision = (double)0;
            m_usefulPrecisionLatLon = (int)0;
            m_usefulPrecisionAlt = (int)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "N_S_Hemisphere", IsRequired = false, Order = 1)]
        public string N_S_Hemisphere
        {
            get { return m_n_S_Hemisphere;  }
            set { m_n_S_Hemisphere = value; }
        }

        /// <remarks />
        [DataMember(Name = "Latitude", IsRequired = false, Order = 2)]
        public double Latitude
        {
            get { return m_latitude;  }
            set { m_latitude = value; }
        }

        /// <remarks />
        [DataMember(Name = "E_W_Hemisphere", IsRequired = false, Order = 3)]
        public string E_W_Hemisphere
        {
            get { return m_e_W_Hemisphere;  }
            set { m_e_W_Hemisphere = value; }
        }

        /// <remarks />
        [DataMember(Name = "Longitude", IsRequired = false, Order = 4)]
        public double Longitude
        {
            get { return m_longitude;  }
            set { m_longitude = value; }
        }

        /// <remarks />
        [DataMember(Name = "Altitude", IsRequired = false, Order = 5)]
        public double Altitude
        {
            get { return m_altitude;  }
            set { m_altitude = value; }
        }

        /// <remarks />
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 6)]
        public DateTime Timestamp
        {
            get { return m_timestamp;  }
            set { m_timestamp = value; }
        }

        /// <remarks />
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 7)]
        public double DilutionOfPrecision
        {
            get { return m_dilutionOfPrecision;  }
            set { m_dilutionOfPrecision = value; }
        }

        /// <remarks />
        [DataMember(Name = "UsefulPrecisionLatLon", IsRequired = false, Order = 8)]
        public int UsefulPrecisionLatLon
        {
            get { return m_usefulPrecisionLatLon;  }
            set { m_usefulPrecisionLatLon = value; }
        }

        /// <remarks />
        [DataMember(Name = "UsefulPrecisionAlt", IsRequired = false, Order = 9)]
        public int UsefulPrecisionAlt
        {
            get { return m_usefulPrecisionAlt;  }
            set { m_usefulPrecisionAlt = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.WGS84Coordinate; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.WGS84Coordinate_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.WGS84Coordinate_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            encoder.WriteString("N_S_Hemisphere", N_S_Hemisphere);
            encoder.WriteDouble("Latitude", Latitude);
            encoder.WriteString("E_W_Hemisphere", E_W_Hemisphere);
            encoder.WriteDouble("Longitude", Longitude);
            encoder.WriteDouble("Altitude", Altitude);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecisionLatLon", UsefulPrecisionLatLon);
            encoder.WriteInt32("UsefulPrecisionAlt", UsefulPrecisionAlt);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.AutoID.Namespaces.AutoID);

            N_S_Hemisphere = decoder.ReadString("N_S_Hemisphere");
            Latitude = decoder.ReadDouble("Latitude");
            E_W_Hemisphere = decoder.ReadString("E_W_Hemisphere");
            Longitude = decoder.ReadDouble("Longitude");
            Altitude = decoder.ReadDouble("Altitude");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecisionLatLon = decoder.ReadInt32("UsefulPrecisionLatLon");
            UsefulPrecisionAlt = decoder.ReadInt32("UsefulPrecisionAlt");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            WGS84Coordinate value = encodeable as WGS84Coordinate;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_n_S_Hemisphere, value.m_n_S_Hemisphere)) return false;
            if (!Utils.IsEqual(m_latitude, value.m_latitude)) return false;
            if (!Utils.IsEqual(m_e_W_Hemisphere, value.m_e_W_Hemisphere)) return false;
            if (!Utils.IsEqual(m_longitude, value.m_longitude)) return false;
            if (!Utils.IsEqual(m_altitude, value.m_altitude)) return false;
            if (!Utils.IsEqual(m_timestamp, value.m_timestamp)) return false;
            if (!Utils.IsEqual(m_dilutionOfPrecision, value.m_dilutionOfPrecision)) return false;
            if (!Utils.IsEqual(m_usefulPrecisionLatLon, value.m_usefulPrecisionLatLon)) return false;
            if (!Utils.IsEqual(m_usefulPrecisionAlt, value.m_usefulPrecisionAlt)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (WGS84Coordinate)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WGS84Coordinate clone = (WGS84Coordinate)base.MemberwiseClone();

            clone.m_n_S_Hemisphere = (string)Utils.Clone(this.m_n_S_Hemisphere);
            clone.m_latitude = (double)Utils.Clone(this.m_latitude);
            clone.m_e_W_Hemisphere = (string)Utils.Clone(this.m_e_W_Hemisphere);
            clone.m_longitude = (double)Utils.Clone(this.m_longitude);
            clone.m_altitude = (double)Utils.Clone(this.m_altitude);
            clone.m_timestamp = (DateTime)Utils.Clone(this.m_timestamp);
            clone.m_dilutionOfPrecision = (double)Utils.Clone(this.m_dilutionOfPrecision);
            clone.m_usefulPrecisionLatLon = (int)Utils.Clone(this.m_usefulPrecisionLatLon);
            clone.m_usefulPrecisionAlt = (int)Utils.Clone(this.m_usefulPrecisionAlt);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_n_S_Hemisphere;
        private double m_latitude;
        private string m_e_W_Hemisphere;
        private double m_longitude;
        private double m_altitude;
        private DateTime m_timestamp;
        private double m_dilutionOfPrecision;
        private int m_usefulPrecisionLatLon;
        private int m_usefulPrecisionAlt;
        #endregion
    }

    #region WGS84CoordinateCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfWGS84Coordinate", Namespace = Opc.Ua.AutoID.Namespaces.AutoID, ItemName = "WGS84Coordinate")]
    #if !NET_STANDARD
    public partial class WGS84CoordinateCollection : List<WGS84Coordinate>, ICloneable
    #else
    public partial class WGS84CoordinateCollection : List<WGS84Coordinate>
    #endif
    {
        #region Constructors
        /// <remarks />
        public WGS84CoordinateCollection() {}

        /// <remarks />
        public WGS84CoordinateCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public WGS84CoordinateCollection(IEnumerable<WGS84Coordinate> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator WGS84CoordinateCollection(WGS84Coordinate[] values)
        {
            if (values != null)
            {
                return new WGS84CoordinateCollection(values);
            }

            return new WGS84CoordinateCollection();
        }

        /// <remarks />
        public static explicit operator WGS84Coordinate[](WGS84CoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (WGS84CoordinateCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WGS84CoordinateCollection clone = new WGS84CoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((WGS84Coordinate)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
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
    #region LocationVariableTypeState Class
    #if (!OPCUA_EXCLUDE_LocationVariableTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LocationVariableTypeState : BaseDataVariableState<Opc.Ua.AutoID.Location>
    {
        #region Constructors
        /// <remarks />
        public LocationVariableTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.VariableTypes.LocationVariableType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.DataTypes.Location, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (GeographicalUnit != null)
            {
                GeographicalUnit.Initialize(context, GeographicalUnit_InitializationString);
            }

            if (LengthUnit != null)
            {
                LengthUnit.Initialize(context, LengthUnit_InitializationString);
            }

            if (RotationalUnit != null)
            {
                RotationalUnit.Initialize(context, RotationalUnit_InitializationString);
            }

            if (SpeedUnit != null)
            {
                SpeedUnit.Initialize(context, SpeedUnit_InitializationString);
            }
        }

        #region Initialization String
        private const string GeographicalUnit_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAAR2VvZ3JhcGhpY2FsVW5pdAEBNxgALgBE" +
           "NxgAAAEAdwP/////AwP/////AAAAAA==";

        private const string LengthUnit_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAKAAAATGVuZ3RoVW5pdAEBNRgALgBENRgAAAEA" +
           "dwP/////AwP/////AAAAAA==";

        private const string RotationalUnit_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAOAAAAUm90YXRpb25hbFVuaXQBATYYAC4ARDYY" +
           "AAABAHcD/////wMD/////wAAAAA=";

        private const string SpeedUnit_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAJAAAAU3BlZWRVbml0AQE4GAAuAEQ4GAAAAQB3" +
           "A/////8DA/////8AAAAA";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQICAAAAAQAcAAAATG9jYXRpb25WYXJpYWJsZVR5cGVJbnN0" +
           "YW5jZQEB0gcBAdIH0gcAAAEBwAv/////AQH/////BAAAABVgiQoCAAAAAQAQAAAAR2VvZ3JhcGhpY2Fs" +
           "VW5pdAEBNxgALgBENxgAAAEAdwP/////AwP/////AAAAABVgiQoCAAAAAQAKAAAATGVuZ3RoVW5pdAEB" +
           "NRgALgBENRgAAAEAdwP/////AwP/////AAAAABVgiQoCAAAAAQAOAAAAUm90YXRpb25hbFVuaXQBATYY" +
           "AC4ARDYYAAABAHcD/////wMD/////wAAAAAVYIkKAgAAAAEACQAAAFNwZWVkVW5pdAEBOBgALgBEOBgA" +
           "AAEAdwP/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<EUInformation> GeographicalUnit
        {
            get
            {
                return m_geographicalUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_geographicalUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_geographicalUnit = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> LengthUnit
        {
            get
            {
                return m_lengthUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lengthUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lengthUnit = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> RotationalUnit
        {
            get
            {
                return m_rotationalUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotationalUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotationalUnit = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> SpeedUnit
        {
            get
            {
                return m_speedUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speedUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speedUnit = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_geographicalUnit != null)
            {
                children.Add(m_geographicalUnit);
            }

            if (m_lengthUnit != null)
            {
                children.Add(m_lengthUnit);
            }

            if (m_rotationalUnit != null)
            {
                children.Add(m_rotationalUnit);
            }

            if (m_speedUnit != null)
            {
                children.Add(m_speedUnit);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.GeographicalUnit:
                {
                    if (createOrReplace)
                    {
                        if (GeographicalUnit == null)
                        {
                            if (replacement == null)
                            {
                                GeographicalUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                GeographicalUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = GeographicalUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LengthUnit:
                {
                    if (createOrReplace)
                    {
                        if (LengthUnit == null)
                        {
                            if (replacement == null)
                            {
                                LengthUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                LengthUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = LengthUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.RotationalUnit:
                {
                    if (createOrReplace)
                    {
                        if (RotationalUnit == null)
                        {
                            if (replacement == null)
                            {
                                RotationalUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                RotationalUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = RotationalUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.SpeedUnit:
                {
                    if (createOrReplace)
                    {
                        if (SpeedUnit == null)
                        {
                            if (replacement == null)
                            {
                                SpeedUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                SpeedUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = SpeedUnit;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<EUInformation> m_geographicalUnit;
        private PropertyState<EUInformation> m_lengthUnit;
        private PropertyState<EUInformation> m_rotationalUnit;
        private PropertyState<EUInformation> m_speedUnit;
        #endregion
    }
    #endif
    #endregion

    #region AutoIdDiagnosticsEventTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdDiagnosticsEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdDiagnosticsEventTypeState : BaseEventState
    {
        #region Constructors
        /// <remarks />
        public AutoIdDiagnosticsEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdDiagnosticsEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAiAAAAQXV0b0lkRGlhZ25vc3RpY3NFdmVudFR5" +
           "cGVJbnN0YW5jZQEB8gMBAfID8gMAAP////8JAAAAFWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQA" +
           "D/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAA" +
           "CgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAA" +
           "AC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBEABX/////AQH/////AAAAABVg" +
           "iQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAERl" +
           "dmljZU5hbWUBAcoXAwAAAAAqAAAATmFtZSBvZiB0aGUgZGV2aWNlIG9mIHRoZSBkaWFnbm9zdGljIGRh" +
           "dGEuAC4ARMoXAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> DeviceName
        {
            get
            {
                return m_deviceName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceName = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceName != null)
            {
                children.Add(m_deviceName);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.DeviceName:
                {
                    if (createOrReplace)
                    {
                        if (DeviceName == null)
                        {
                            if (replacement == null)
                            {
                                DeviceName = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceName;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_deviceName;
        #endregion
    }
    #endif
    #endregion

    #region AutoIdAccessEventTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdAccessEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdAccessEventTypeState : AutoIdDiagnosticsEventTypeState
    {
        #region Constructors
        /// <remarks />
        public AutoIdAccessEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdAccessEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Client != null)
            {
                Client.Initialize(context, Client_InitializationString);
            }

            if (Command != null)
            {
                Command.Initialize(context, Command_InitializationString);
            }
        }

        #region Initialization String
        private const string Client_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAGAAAAQ2xpZW50AQHMFwMAAAAALwAAAENsaWVu" +
           "dCB3aGljaCB3YXMgdGhlIG9yaWdpbmF0b3Igb2YgdGhlIGNvbW1hbmQuAC4ARMwXAAAADP////8BAf//" +
           "//8AAAAA";

        private const string Command_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAHAAAAQ29tbWFuZAEBzRcDAAAAAA4AAABBY2Nl" +
           "c3MgY29tbWFuZAAuAETNFwAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAdAAAAQXV0b0lkQWNjZXNzRXZlbnRUeXBlSW5z" +
           "dGFuY2UBAfcDAQH3A/cDAAABAAAAACkBAQHpAwwAAAAVYIkIAgAAAAAABwAAAEV2ZW50SWQBAQAAAC4A" +
           "RAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/////AQH/////" +
           "AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAA" +
           "AAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAEAAAAVGltZQEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEBAAAALgBEAQAm" +
           "Af////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAAADVgiQoCAAAAAQAKAAAA" +
           "RGV2aWNlTmFtZQEByhcDAAAAACoAAABOYW1lIG9mIHRoZSBkZXZpY2Ugb2YgdGhlIGRpYWdub3N0aWMg" +
           "ZGF0YS4ALgBEyhcAAAAM/////wEB/////wAAAAA3YIkKAgAAAAEADAAAAEFjY2Vzc1Jlc3VsdAEByxcD" +
           "AAAAABwAAABSZXN1bHQgdmFsdWVzIG9mIHRoZSBhY2Nlc3MuAC4ARMsXAAABAckLAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAADVgiQoCAAAAAQAGAAAAQ2xpZW50AQHMFwMAAAAALwAAAENsaWVudCB3aGljaCB3YXMg" +
           "dGhlIG9yaWdpbmF0b3Igb2YgdGhlIGNvbW1hbmQuAC4ARMwXAAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAABAAcAAABDb21tYW5kAQHNFwMAAAAADgAAAEFjY2VzcyBjb21tYW5kAC4ARM0XAAAADP////8BAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<AccessResult[]> AccessResult
        {
            get
            {
                return m_accessResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessResult = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Client
        {
            get
            {
                return m_client;
            }

            set
            {
                if (!Object.ReferenceEquals(m_client, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_client = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Command
        {
            get
            {
                return m_command;
            }

            set
            {
                if (!Object.ReferenceEquals(m_command, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_command = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_accessResult != null)
            {
                children.Add(m_accessResult);
            }

            if (m_client != null)
            {
                children.Add(m_client);
            }

            if (m_command != null)
            {
                children.Add(m_command);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.AccessResult:
                {
                    if (createOrReplace)
                    {
                        if (AccessResult == null)
                        {
                            if (replacement == null)
                            {
                                AccessResult = new PropertyState<AccessResult[]>(this);
                            }
                            else
                            {
                                AccessResult = (PropertyState<AccessResult[]>)replacement;
                            }
                        }
                    }

                    instance = AccessResult;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.Client:
                {
                    if (createOrReplace)
                    {
                        if (Client == null)
                        {
                            if (replacement == null)
                            {
                                Client = new PropertyState<string>(this);
                            }
                            else
                            {
                                Client = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Client;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.Command:
                {
                    if (createOrReplace)
                    {
                        if (Command == null)
                        {
                            if (replacement == null)
                            {
                                Command = new PropertyState<string>(this);
                            }
                            else
                            {
                                Command = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Command;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<AccessResult[]> m_accessResult;
        private PropertyState<string> m_client;
        private PropertyState<string> m_command;
        #endregion
    }
    #endif
    #endregion

    #region RfidAccessEventTypeState Class
    #if (!OPCUA_EXCLUDE_RfidAccessEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RfidAccessEventTypeState : AutoIdAccessEventTypeState
    {
        #region Constructors
        /// <remarks />
        public RfidAccessEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.RfidAccessEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAUmZpZEFjY2Vzc0V2ZW50VHlwZUluc3Rh" +
           "bmNlAQH4AwEB+AP4AwAAAQAAAAApAQEB6wMKAAAAFWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQA" +
           "D/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAA" +
           "CgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAA" +
           "AC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBEABX/////AQH/////AAAAABVg" +
           "iQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAERl" +
           "dmljZU5hbWUBAcoXAwAAAAAqAAAATmFtZSBvZiB0aGUgZGV2aWNlIG9mIHRoZSBkaWFnbm9zdGljIGRh" +
           "dGEuAC4ARMoXAAAADP////8BAf////8AAAAAN2CJCgIAAAABAAwAAABBY2Nlc3NSZXN1bHQBAc4XAwAA" +
           "AAAcAAAAUmVzdWx0IHZhbHVlcyBvZiB0aGUgYWNjZXNzLgAuAETOFwAAAQHKCwEAAAABAAAAAAAAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<RfidAccessResult[]> AccessResult
        {
            get
            {
                return m_accessResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.AccessResult:
                {
                    if (createOrReplace)
                    {
                        if (AccessResult == null)
                        {
                            if (replacement == null)
                            {
                                AccessResult = new PropertyState<RfidAccessResult[]>(this);
                            }
                            else
                            {
                                AccessResult = (PropertyState<RfidAccessResult[]>)replacement;
                            }
                        }
                    }

                    instance = AccessResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<RfidAccessResult[]> m_accessResult;
        #endregion
    }
    #endif
    #endregion

    #region AutoIdLogEntryEventTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdLogEntryEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdLogEntryEventTypeState : AutoIdDiagnosticsEventTypeState
    {
        #region Constructors
        /// <remarks />
        public AutoIdLogEntryEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdLogEntryEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAfAAAAQXV0b0lkTG9nRW50cnlFdmVudFR5cGVJ" +
           "bnN0YW5jZQEB+QMBAfkD+QMAAAEAAAAAKQEBAekDCQAAABVgiQgCAAAAAAAHAAAARXZlbnRJZAEBAAAA" +
           "LgBEAA//////AQH/////AAAAABVgiQgCAAAAAAAJAAAARXZlbnRUeXBlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIA" +
           "AAAAAAoAAABTb3VyY2VOYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAQAAABUaW1l" +
           "AQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEAAAAuAEQB" +
           "ACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1lc3NhZ2UBAQAAAC4ARAAV/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQABf////8BAf////8AAAAANWCJCgIAAAABAAoA" +
           "AABEZXZpY2VOYW1lAQHKFwMAAAAAKgAAAE5hbWUgb2YgdGhlIGRldmljZSBvZiB0aGUgZGlhZ25vc3Rp" +
           "YyBkYXRhLgAuAETKFwAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AutoIdPresenceEventTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdPresenceEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdPresenceEventTypeState : AutoIdDiagnosticsEventTypeState
    {
        #region Constructors
        /// <remarks />
        public AutoIdPresenceEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdPresenceEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAfAAAAQXV0b0lkUHJlc2VuY2VFdmVudFR5cGVJ" +
           "bnN0YW5jZQEB+gMBAfoD+gMAAAEAAAAAKQEBAekDCgAAABVgiQgCAAAAAAAHAAAARXZlbnRJZAEBAAAA" +
           "LgBEAA//////AQH/////AAAAABVgiQgCAAAAAAAJAAAARXZlbnRUeXBlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIA" +
           "AAAAAAoAAABTb3VyY2VOYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAQAAABUaW1l" +
           "AQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEAAAAuAEQB" +
           "ACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1lc3NhZ2UBAQAAAC4ARAAV/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQABf////8BAf////8AAAAANWCJCgIAAAABAAoA" +
           "AABEZXZpY2VOYW1lAQHKFwMAAAAAKgAAAE5hbWUgb2YgdGhlIGRldmljZSBvZiB0aGUgZGlhZ25vc3Rp" +
           "YyBkYXRhLgAuAETKFwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAIAAAAUHJlc2VuY2UBAc8XAwAA" +
           "AAAmAAAAQ3VycmVudCBwcmVzZW5jZSBvZiBBdXRvSUQgSWRlbnRpZmllci4ALgBEzxcAAAAF/////wEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> Presence
        {
            get
            {
                return m_presence;
            }

            set
            {
                if (!Object.ReferenceEquals(m_presence, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_presence = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_presence != null)
            {
                children.Add(m_presence);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.Presence:
                {
                    if (createOrReplace)
                    {
                        if (Presence == null)
                        {
                            if (replacement == null)
                            {
                                Presence = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                Presence = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Presence;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_presence;
        #endregion
    }
    #endif
    #endregion

    #region AutoIdScanEventTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdScanEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdScanEventTypeState : BaseEventState
    {
        #region Constructors
        /// <remarks />
        public AutoIdScanEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdScanEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAQXV0b0lkU2NhbkV2ZW50VHlwZUluc3Rh" +
           "bmNlAQHsAwEB7APsAwAAAQAAAAApAQEB6QMKAAAAFWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQA" +
           "D/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAA" +
           "CgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAA" +
           "AC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBEABX/////AQH/////AAAAABVg" +
           "iQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAERl" +
           "dmljZU5hbWUBAaEXAC4ARKEXAAAADP////8BAf////8AAAAAF2CJCgIAAAABAAoAAABTY2FuUmVzdWx0" +
           "AQGIFwAuAESIFwAAAQG5CwEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> DeviceName
        {
            get
            {
                return m_deviceName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceName = value;
            }
        }

        /// <remarks />
        public PropertyState<ScanResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceName != null)
            {
                children.Add(m_deviceName);
            }

            if (m_scanResult != null)
            {
                children.Add(m_scanResult);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.DeviceName:
                {
                    if (createOrReplace)
                    {
                        if (DeviceName == null)
                        {
                            if (replacement == null)
                            {
                                DeviceName = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceName;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<ScanResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<ScanResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_deviceName;
        private PropertyState<ScanResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region OcrScanEventTypeState Class
    #if (!OPCUA_EXCLUDE_OcrScanEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OcrScanEventTypeState : AutoIdScanEventTypeState
    {
        #region Constructors
        /// <remarks />
        public OcrScanEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OcrScanEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAYAAAAT2NyU2NhbkV2ZW50VHlwZUluc3RhbmNl" +
           "AQHtAwEB7QPtAwAAAQAAAAApAQEB6gMKAAAAFWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQAD///" +
           "//8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAA" +
           "AFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAAAC4A" +
           "RAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBEABX/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAERldmlj" +
           "ZU5hbWUBAaEXAC4ARKEXAAAADP////8BAf////8AAAAAF2CJCgIAAAABAAoAAABTY2FuUmVzdWx0AQGZ" +
           "FwAuAESZFwAAAQG6CwEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<OcrScanResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<OcrScanResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<OcrScanResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<OcrScanResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region OpticalScanEventTypeState Class
    #if (!OPCUA_EXCLUDE_OpticalScanEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalScanEventTypeState : AutoIdScanEventTypeState
    {
        #region Constructors
        /// <remarks />
        public OpticalScanEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OpticalScanEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAcAAAAT3B0aWNhbFNjYW5FdmVudFR5cGVJbnN0" +
           "YW5jZQEB8QMBAfED8QMAAAEAAAAAKQEBAfADCgAAABVgiQgCAAAAAAAHAAAARXZlbnRJZAEBAAAALgBE" +
           "AA//////AQH/////AAAAABVgiQgCAAAAAAAJAAAARXZlbnRUeXBlAQEAAAAuAEQAEf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AAoAAABTb3VyY2VOYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAQAAABUaW1lAQEA" +
           "AAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEAAAAuAEQBACYB" +
           "/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1lc3NhZ2UBAQAAAC4ARAAV/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQABf////8BAf////8AAAAAFWCJCgIAAAABAAoAAABE" +
           "ZXZpY2VOYW1lAQGhFwAuAEShFwAAAAz/////AQH/////AAAAABdgiQoCAAAAAQAKAAAAU2NhblJlc3Vs" +
           "dAEBAxgALgBEAxgAAAEB0gsBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<OpticalScanResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<OpticalScanResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<OpticalScanResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<OpticalScanResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region OpticalVerifierScanEventTypeState Class
    #if (!OPCUA_EXCLUDE_OpticalVerifierScanEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalVerifierScanEventTypeState : OpticalScanEventTypeState
    {
        #region Constructors
        /// <remarks />
        public OpticalVerifierScanEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OpticalVerifierScanEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAAT3B0aWNhbFZlcmlmaWVyU2NhbkV2ZW50" +
           "VHlwZUluc3RhbmNlAQH1AwEB9QP1AwAAAQAAAAApAQEB8wMKAAAAFWCJCAIAAAAAAAcAAABFdmVudElk" +
           "AQEAAAAuAEQAD/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAAAC4ARAAR////" +
           "/wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAACgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAABAAA" +
           "AFRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAA" +
           "AC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBEABX/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACgAAAERldmljZU5hbWUBAaEXAC4ARKEXAAAADP////8BAf////8AAAAAF2CJCgIAAAABAAoAAABT" +
           "Y2FuUmVzdWx0AQFTGAAuAERTGAAAAQHWCwEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<OpticalVerifierScanResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<OpticalVerifierScanResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<OpticalVerifierScanResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<OpticalVerifierScanResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region RfidScanEventTypeState Class
    #if (!OPCUA_EXCLUDE_RfidScanEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RfidScanEventTypeState : AutoIdScanEventTypeState
    {
        #region Constructors
        /// <remarks />
        public RfidScanEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.RfidScanEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAZAAAAUmZpZFNjYW5FdmVudFR5cGVJbnN0YW5j" +
           "ZQEB7gMBAe4D7gMAAAEAAAAAKQEBAesDCgAAABVgiQgCAAAAAAAHAAAARXZlbnRJZAEBAAAALgBEAA//" +
           "////AQH/////AAAAABVgiQgCAAAAAAAJAAAARXZlbnRUeXBlAQEAAAAuAEQAEf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAAAoA" +
           "AABTb3VyY2VOYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAQAAABUaW1lAQEAAAAu" +
           "AEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEAAAAuAEQBACYB////" +
           "/wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1lc3NhZ2UBAQAAAC4ARAAV/////wEB/////wAAAAAVYIkI" +
           "AgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQABf////8BAf////8AAAAAFWCJCgIAAAABAAoAAABEZXZp" +
           "Y2VOYW1lAQGhFwAuAEShFwAAAAz/////AQH/////AAAAABdgiQoCAAAAAQAKAAAAU2NhblJlc3VsdAEB" +
           "mhcALgBEmhcAAAEBvwsBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<RfidScanResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<RfidScanResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<RfidScanResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<RfidScanResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region RtlsLocationEventTypeState Class
    #if (!OPCUA_EXCLUDE_RtlsLocationEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RtlsLocationEventTypeState : AutoIdScanEventTypeState
    {
        #region Constructors
        /// <remarks />
        public RtlsLocationEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.RtlsLocationEventType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAdAAAAUnRsc0xvY2F0aW9uRXZlbnRUeXBlSW5z" +
           "dGFuY2UBAfYDAQH2A/YDAAABAAAAACkBAQH0AwoAAAAVYIkIAgAAAAAABwAAAEV2ZW50SWQBAQAAAC4A" +
           "RAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/////AQH/////" +
           "AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAA" +
           "AAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAEAAAAVGltZQEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEBAAAALgBEAQAm" +
           "Af////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAAABVgiQoCAAAAAQAKAAAA" +
           "RGV2aWNlTmFtZQEBoRcALgBEoRcAAAAM/////wEB/////wAAAAAXYIkKAgAAAAEACgAAAFNjYW5SZXN1" +
           "bHQBAVQYAC4ARFQYAAABAdQLAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new PropertyState<RtlsLocationResult[]> ScanResult
        {
            get
            {
                return m_scanResult;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanResult, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanResult = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.ScanResult:
                {
                    if (createOrReplace)
                    {
                        if (ScanResult == null)
                        {
                            if (replacement == null)
                            {
                                ScanResult = new PropertyState<RtlsLocationResult[]>(this);
                            }
                            else
                            {
                                ScanResult = (PropertyState<RtlsLocationResult[]>)replacement;
                            }
                        }
                    }

                    instance = ScanResult;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<RtlsLocationResult[]> m_scanResult;
        #endregion
    }
    #endif
    #endregion

    #region AutoIdDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_AutoIdDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoIdDeviceTypeState : DeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public AutoIdDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.AutoIdDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DeviceInfo != null)
            {
                DeviceInfo.Initialize(context, DeviceInfo_InitializationString);
            }

            if (DeviceLocation != null)
            {
                DeviceLocation.Initialize(context, DeviceLocation_InitializationString);
            }

            if (DeviceLocationName != null)
            {
                DeviceLocationName.Initialize(context, DeviceLocationName_InitializationString);
            }

            if (Diagnostics != null)
            {
                Diagnostics.Initialize(context, Diagnostics_InitializationString);
            }

            if (GetDeviceLocation != null)
            {
                GetDeviceLocation.Initialize(context, GetDeviceLocation_InitializationString);
            }

            if (IOData != null)
            {
                IOData.Initialize(context, IOData_InitializationString);
            }

            if (LastScanData != null)
            {
                LastScanData.Initialize(context, LastScanData_InitializationString);
            }

            if (LastScanTimestamp != null)
            {
                LastScanTimestamp.Initialize(context, LastScanTimestamp_InitializationString);
            }

            if (RuntimeParameters != null)
            {
                RuntimeParameters.Initialize(context, RuntimeParameters_InitializationString);
            }

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }

            if (ScanActive != null)
            {
                ScanActive.Initialize(context, ScanActive_InitializationString);
            }

            if (ScanStart != null)
            {
                ScanStart.Initialize(context, ScanStart_InitializationString);
            }

            if (ScanStop != null)
            {
                ScanStop.Initialize(context, ScanStop_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceInfo_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAARGV2aWNlSW5mbwEBihcDAAAAABoAAABE" +
           "ZXZpY2Ugc3RhdHVzIGluZm9ybWF0aW9uLgAuAESKFwAAAAz/////AwP/////AAAAAA==";

        private const string DeviceLocation_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAOAAAARGV2aWNlTG9jYXRpb24BAfAXAwAAAAAZ" +
           "AAAAVW5pb24gb2YgR1BTLCBVVE0sIExvY2FsLgAvAQHSB/AXAAABAcAL/////wMD/////wAAAAA=";

        private const string DeviceLocationName_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQASAAAARGV2aWNlTG9jYXRpb25OYW1lAQHvFwMA" +
           "AAAAJQAAAFN5bWJvbGljIG5hbWUgb2YgdGhlIGRldmljZSBsb2NhdGlvbi4ALgBE7xcAAAAM/////wMD" +
           "/////wAAAAA=";

        private const string Diagnostics_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQALAAAARGlhZ25vc3RpY3MBAaITAwAAAAAkAAAA" +
           "RGlhZ25vc3RpYyBkYXRhIGZyb20gQXV0b0lEIERldmljZXMuAC8BAu0DohMAAP////8DAAAAJGCACgEA" +
           "AAABAAoAAABMYXN0QWNjZXNzAQGjEwMAAAAALAAAAFZhbHVlcyBvZiB0aGUgbGFzdCBBdXRvSUQgSWRl" +
           "bnRpZmllciBhY2Nlc3MuAC8BAu0DoxMAAP////8EAAAANWCJCgIAAAABAAYAAABDbGllbnQBAdcXAwAA" +
           "AAAvAAAAQ2xpZW50IHdoaWNoIHdhcyB0aGUgb3JpZ2luYXRvciBvZiB0aGUgY29tbWFuZC4ALwA/1xcA" +
           "AAAM/////wMD/////wAAAAA1YIkKAgAAAAEABwAAAENvbW1hbmQBAdgXAwAAAAAOAAAAQWNjZXNzIGNv" +
           "bW1hbmQALwA/2BcAAAAM/////wMD/////wAAAAA1YIkKAgAAAAEACgAAAElkZW50aWZpZXIBAdkXAwAA" +
           "AABVAAAAVGhlIEF1dG9JRCBJZGVudGlmaWVyIChlLmcuIGEgY29kZSBvciBhIHRyYW5zcG9uZGVyKSB3" +
           "aGljaCB3YXMgYWNjZXNzZWQgYnkgYSBjb21tYW5kLgAvAD/ZFwAAABj/////AwP/////AAAAADVgiQoC" +
           "AAAAAQAJAAAAVGltZXN0YW1wAQHaFwMAAAAARAAAAFRoZSBwb2ludCBvZiB0aW1lIHRoZSBBdXRvSUQg" +
           "SWRlbnRpZmllciB3YXMgYWNjZXNzZWQgYnkgdGhlIGNvbW1hbmQuAC8AP9oXAAABACYB/////wMD////" +
           "/wAAAAAkYIAKAQAAAAEABwAAAExvZ2Jvb2sBAagTAwAAAAAWAAAAVmFsdWVzIG9mIHRoZSBsb2dib29r" +
           "LgAvAQLtA6gTAAD/////AgAAADVgiQoCAAAAAQAMAAAATGFzdExvZ0VudHJ5AQHWFwMAAAAAIAAAAENv" +
           "bHVtbiBoZWFkaW5ncyBvZiB0aGUgTG9vZ2Jvb2suAC8AP9YXAAAADP////8DA/////8AAAAANWCJCgIA" +
           "AAABAAoAAABMb2dDb2x1bW5zAQHVFwMAAAAAGwAAAExhc3QgRW50cnkgb2YgdGhlIExvb2dib29rLgAv" +
           "AD/VFwAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAIAAAAUHJlc2VuY2UBAdQXAwAAAABFAAAAQ3Vy" +
           "cmVudCBwcmVzZW5jZSBvZiBBdXRvSUQgSWRlbnRpZmllciAoZS5nLiBhIGNvZGUgb3IgYSB0cmFuc3Bv" +
           "bmRlcikuAC8AP9QXAAAABf////8DA/////8AAAAA";

        private const string GetDeviceLocation_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQARAAAAR2V0RGV2aWNlTG9jYXRpb24BAYIbAC8B" +
           "AYIbghsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHyFwAuAETyFwAAlgEA" +
           "AAABACoBAR0AAAAMAAAATG9jYXRpb25UeXBlAQHBC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAfEXAC4ARPEXAACWAQAAAAEAKgEBNwAA" +
           "AAgAAABMb2NhdGlvbgEBwAv/////AAAAAAIaAAAAVW5pb24gb2YgR1BTLCBVVE0gb3IgTG9jYWwBACgB" +
           "AQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string IOData_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAGAAAASU9EYXRhAQG+EwAvAQLtA74TAAD/////" +
           "AAAAAA==";

        private const string LastScanData_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAMAAAATGFzdFNjYW5EYXRhAQGnFwMAAAAAIwAA" +
           "AFRoZSBsYXN0IHNjYW5uZWQgQXV0b0lEIElkZW50aWZpZXIuAC8AP6cXAAAAGP////8DA/////8AAAAA";

        private const string LastScanTimestamp_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQARAAAATGFzdFNjYW5UaW1lc3RhbXABAdAXAwAA" +
           "AAA1AAAAUG9pbnQgb2YgdGltZSB0aGUgbGFzdCBBdXRvSUQgSWRlbnRpZmllciB3YXMgc2Nhbm5lZC4A" +
           "LwA/0BcAAAEAJgH/////AwP/////AAAAAA==";

        private const string RuntimeParameters_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQARAAAAUnVudGltZVBhcmFtZXRlcnMBAbQTAC8B" +
           "Au0DtBMAAP////8CAAAAN2CJCgIAAAABAAkAAABDb2RlVHlwZXMBAdsXAwAAAAA7AAAAU3VwcG9ydGVk" +
           "IENvZGVUeXBlcyBhbmQgc2VsZWN0ZWQgQ29kZVR5cGUgZm9yIHRoZSBTY2FuRGF0YS4ALwEASAnbFwAA" +
           "AAcBAAAAAQAAAAAAAAADA/////8BAAAAF2CJCgIAAAAAAAsAAABFbnVtU3RyaW5ncwEB3BcALgBE3BcA" +
           "AAAVAQAAAAEAAAAAAAAAAQH/////AAAAACRggAoBAAAAAQAMAAAAU2NhblNldHRpbmdzAQGpEwMAAAAA" +
           "NQAAAFNjYW4gc2V0dGluZ3MgdXNlZCB0b2dldGhlciB3aXRoIFNjYW5BY3RpdmUgVmFyaWFibGUuAC8B" +
           "Au0DqRMAAP////8EAAAANWCJCgIAAAABAAgAAABDb2RlVHlwZQEB3RcDAAAAAC4AAABUaGUgZm9ybWF0" +
           "IG9mIExhc3RTY2FuRGF0YSBWYXJpYWJsZSBhcyBzdHJpbmcuAC8AP90XAAABAdcL/////wMD/////wAA" +
           "AAA1YIkKAgAAAAEABgAAAEN5Y2xlcwEB3xcDAAAAADgAAABEdXJhdGlvbiBvZiB0aGUgc2NhbiBvcGVy" +
           "YXRpb24gaW4gbnVtYmVyIG9mIHNjYW4gY3ljbGVzLgAvAD/fFwAAAAb/////AwP/////AAAAADVgiQoC" +
           "AAAAAQANAAAARGF0YUF2YWlsYWJsZQEB3hcDAAAAADgAAABGaW5pc2ggc2NhbiBvcGVyYXRpb24gYXMg" +
           "c29vbiBhcyBzY2FuIGRhdGEgaXMgYXZhaWxhYmxlLgAvAD/eFwAAAAH/////AwP/////AAAAADVgiQoC" +
           "AAAAAQAIAAAARHVyYXRpb24BAeAXAwAAAAAvAAAARHVyYXRpb24gb2YgdGhlIHNjYW4gb3BlcmF0aW9u" +
           "IGluIG1pbGxpc2Vjb25kcy4ALwA/4BcAAAEAIgH/////AwP/////AAAAAA==";

        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBYBsALwEBYBtgGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaIXAC4ARKIXAACWAQAAAAEAKgEBGQAAAAgA" +
           "AABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQFxFwAuAERxFwAAlgIAAAABACoBARgAAAAHAAAAUmVzdWx0cwEBuQsB" +
           "AAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAA";

        private const string ScanActive_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAAU2NhbkFjdGl2ZQEB0xcDAAAAABoAAABU" +
           "cmlnZ2VycyB0aGUgc2NhbiBwcm9jZXNzLgAvAD/TFwAAAAH/////AwP/////AAAAAA==";

        private const string ScanStart_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAJAAAAU2NhblN0YXJ0AQFhGwAvAQFhG2EbAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBoxcALgBEoxcAAJYBAAAAAQAqAQEZ" +
           "AAAACAAAAFNldHRpbmdzAQHCC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUAYAC4AREAYAACWAQAAAAEAKgEBFwAAAAYAAABTdGF0dXMB" +
           "AcUL/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string ScanStop_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAIAAAAU2NhblN0b3ABAWIbAC8BAWIbYhsAAAEB" +
           "/////wAAAAA=";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAYAAAAQXV0b0lkRGV2aWNlVHlwZUluc3RhbmNl" +
           "AQHpAwEB6QPpAwAABAAAAAApAAEB9wMAKQABAfkDACkAAQH6AwApAAEB7AMYAAAANWCJCgIAAAACAAwA" +
           "AABNYW51ZmFjdHVyZXIBAXMXAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0" +
           "dXJlZCB0aGUgZGV2aWNlAC4ARHMXAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB" +
           "dBcDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEdBcAAAAV/////wEB/////wAAAAA1" +
           "YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAXgXAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2Yg" +
           "dGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEeBcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "EAAAAFNvZnR3YXJlUmV2aXNpb24BAXcXAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3" +
           "YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEdxcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DgAAAERldmljZVJldmlzaW9uAQF2FwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhl" +
           "IGRldmljZQAuAER2FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQF1" +
           "FwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdl" +
           "YiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAER1FwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFxFwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1" +
           "bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNl" +
           "AC4ARHEXAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAXIXAwAA" +
           "AABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMg" +
           "dGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARHIXAAAA" +
           "Bv////8BAf////8AAAAAFWCpCgIAAAABABIAAABBdXRvSWRNb2RlbFZlcnNpb24BATEYAC4ARDEYAAAM" +
           "BAAAADEuMDEADP////8DA/////8AAAAANWCJCgIAAAABAAoAAABEZXZpY2VJbmZvAQGKFwMAAAAAGgAA" +
           "AERldmljZSBzdGF0dXMgaW5mb3JtYXRpb24uAC4ARIoXAAAADP////8DA/////8AAAAANWCJCgIAAAAB" +
           "AA4AAABEZXZpY2VMb2NhdGlvbgEB8BcDAAAAABkAAABVbmlvbiBvZiBHUFMsIFVUTSwgTG9jYWwuAC8B" +
           "AdIH8BcAAAEBwAv/////AwP/////AAAAADVgiQoCAAAAAQASAAAARGV2aWNlTG9jYXRpb25OYW1lAQHv" +
           "FwMAAAAAJQAAAFN5bWJvbGljIG5hbWUgb2YgdGhlIGRldmljZSBsb2NhdGlvbi4ALgBE7xcAAAAM////" +
           "/wMD/////wAAAAA1YIkKAgAAAAEACgAAAERldmljZU5hbWUBAewXAwAAAABvAAAARGVmYXVsdCBjb3Vs" +
           "ZCBiZSBhbHNvIGhvc3QgbmFtZSwgSVAgYWRkcmVzcyBvciBNQUMuIFRoaXMgc2hvdWxkIGJlIGEgZmll" +
           "bGQgdGhhdCBjYW4gYmUgY29uZmlndXJlZCBmb3IgYSBkZXZpY2UuAC4AROwXAAAADP////8DA/////8A" +
           "AAAAFWCJCgIAAAABAAwAAABEZXZpY2VTdGF0dXMBAY4XAC8AP44XAAABAbsL/////wEB/////wAAAAAk" +
           "YIAKAQAAAAEACwAAAERpYWdub3N0aWNzAQGiEwMAAAAAJAAAAERpYWdub3N0aWMgZGF0YSBmcm9tIEF1" +
           "dG9JRCBEZXZpY2VzLgAvAQLtA6ITAAD/////AwAAACRggAoBAAAAAQAKAAAATGFzdEFjY2VzcwEBoxMD" +
           "AAAAACwAAABWYWx1ZXMgb2YgdGhlIGxhc3QgQXV0b0lEIElkZW50aWZpZXIgYWNjZXNzLgAvAQLtA6MT" +
           "AAD/////BAAAADVgiQoCAAAAAQAGAAAAQ2xpZW50AQHXFwMAAAAALwAAAENsaWVudCB3aGljaCB3YXMg" +
           "dGhlIG9yaWdpbmF0b3Igb2YgdGhlIGNvbW1hbmQuAC8AP9cXAAAADP////8DA/////8AAAAANWCJCgIA" +
           "AAABAAcAAABDb21tYW5kAQHYFwMAAAAADgAAAEFjY2VzcyBjb21tYW5kAC8AP9gXAAAADP////8DA///" +
           "//8AAAAANWCJCgIAAAABAAoAAABJZGVudGlmaWVyAQHZFwMAAAAAVQAAAFRoZSBBdXRvSUQgSWRlbnRp" +
           "ZmllciAoZS5nLiBhIGNvZGUgb3IgYSB0cmFuc3BvbmRlcikgd2hpY2ggd2FzIGFjY2Vzc2VkIGJ5IGEg" +
           "Y29tbWFuZC4ALwA/2RcAAAAY/////wMD/////wAAAAA1YIkKAgAAAAEACQAAAFRpbWVzdGFtcAEB2hcD" +
           "AAAAAEQAAABUaGUgcG9pbnQgb2YgdGltZSB0aGUgQXV0b0lEIElkZW50aWZpZXIgd2FzIGFjY2Vzc2Vk" +
           "IGJ5IHRoZSBjb21tYW5kLgAvAD/aFwAAAQAmAf////8DA/////8AAAAAJGCACgEAAAABAAcAAABMb2di" +
           "b29rAQGoEwMAAAAAFgAAAFZhbHVlcyBvZiB0aGUgbG9nYm9vay4ALwEC7QOoEwAA/////wIAAAA1YIkK" +
           "AgAAAAEADAAAAExhc3RMb2dFbnRyeQEB1hcDAAAAACAAAABDb2x1bW4gaGVhZGluZ3Mgb2YgdGhlIExv" +
           "b2dib29rLgAvAD/WFwAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAKAAAATG9nQ29sdW1ucwEB1RcD" +
           "AAAAABsAAABMYXN0IEVudHJ5IG9mIHRoZSBMb29nYm9vay4ALwA/1RcAAAAM/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEACAAAAFByZXNlbmNlAQHUFwMAAAAARQAAAEN1cnJlbnQgcHJlc2VuY2Ugb2YgQXV0b0lE" +
           "IElkZW50aWZpZXIgKGUuZy4gYSBjb2RlIG9yIGEgdHJhbnNwb25kZXIpLgAvAD/UFwAAAAX/////AwP/" +
           "////AAAAAARhggoEAAAAAQARAAAAR2V0RGV2aWNlTG9jYXRpb24BAYIbAC8BAYIbghsAAAEB/////wIA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHyFwAuAETyFwAAlgEAAAABACoBAR0AAAAMAAAA" +
           "TG9jYXRpb25UeXBlAQHBC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAfEXAC4ARPEXAACWAQAAAAEAKgEBNwAAAAgAAABMb2NhdGlvbgEB" +
           "wAv/////AAAAAAIaAAAAVW5pb24gb2YgR1BTLCBVVE0gb3IgTG9jYWwBACgBAQAAAAEAAAABAAAAAQH/" +
           "////AAAAAARggAoBAAAAAQAGAAAASU9EYXRhAQG+EwAvAQLtA74TAAD/////AAAAADVgiQoCAAAAAQAM" +
           "AAAATGFzdFNjYW5EYXRhAQGnFwMAAAAAIwAAAFRoZSBsYXN0IHNjYW5uZWQgQXV0b0lEIElkZW50aWZp" +
           "ZXIuAC8AP6cXAAAAGP////8DA/////8AAAAANWCJCgIAAAABABEAAABMYXN0U2NhblRpbWVzdGFtcAEB" +
           "0BcDAAAAADUAAABQb2ludCBvZiB0aW1lIHRoZSBsYXN0IEF1dG9JRCBJZGVudGlmaWVyIHdhcyBzY2Fu" +
           "bmVkLgAvAD/QFwAAAQAmAf////8DA/////8AAAAABGCACgEAAAABABEAAABSdW50aW1lUGFyYW1ldGVy" +
           "cwEBtBMALwEC7QO0EwAA/////wIAAAA3YIkKAgAAAAEACQAAAENvZGVUeXBlcwEB2xcDAAAAADsAAABT" +
           "dXBwb3J0ZWQgQ29kZVR5cGVzIGFuZCBzZWxlY3RlZCBDb2RlVHlwZSBmb3IgdGhlIFNjYW5EYXRhLgAv" +
           "AQBICdsXAAAABwEAAAABAAAAAAAAAAMD/////wEAAAAXYIkKAgAAAAAACwAAAEVudW1TdHJpbmdzAQHc" +
           "FwAuAETcFwAAABUBAAAAAQAAAAAAAAABAf////8AAAAAJGCACgEAAAABAAwAAABTY2FuU2V0dGluZ3MB" +
           "AakTAwAAAAA1AAAAU2NhbiBzZXR0aW5ncyB1c2VkIHRvZ2V0aGVyIHdpdGggU2NhbkFjdGl2ZSBWYXJp" +
           "YWJsZS4ALwEC7QOpEwAA/////wQAAAA1YIkKAgAAAAEACAAAAENvZGVUeXBlAQHdFwMAAAAALgAAAFRo" +
           "ZSBmb3JtYXQgb2YgTGFzdFNjYW5EYXRhIFZhcmlhYmxlIGFzIHN0cmluZy4ALwA/3RcAAAEB1wv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAGAAAAQ3ljbGVzAQHfFwMAAAAAOAAAAER1cmF0aW9uIG9mIHRoZSBz" +
           "Y2FuIG9wZXJhdGlvbiBpbiBudW1iZXIgb2Ygc2NhbiBjeWNsZXMuAC8AP98XAAAABv////8DA/////8A" +
           "AAAANWCJCgIAAAABAA0AAABEYXRhQXZhaWxhYmxlAQHeFwMAAAAAOAAAAEZpbmlzaCBzY2FuIG9wZXJh" +
           "dGlvbiBhcyBzb29uIGFzIHNjYW4gZGF0YSBpcyBhdmFpbGFibGUuAC8AP94XAAAAAf////8DA/////8A" +
           "AAAANWCJCgIAAAABAAgAAABEdXJhdGlvbgEB4BcDAAAAAC8AAABEdXJhdGlvbiBvZiB0aGUgc2NhbiBv" +
           "cGVyYXRpb24gaW4gbWlsbGlzZWNvbmRzLgAvAD/gFwAAAQAiAf////8DA/////8AAAAABGGCCgQAAAAB" +
           "AAQAAABTY2FuAQFgGwAvAQFgG2AbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBohcALgBEohcAAJYBAAAAAQAqAQEZAAAACAAAAFNldHRpbmdzAQHCC/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXEXAC4ARHEXAACW" +
           "AgAAAAEAKgEBGAAAAAcAAABSZXN1bHRzAQG5CwEAAAAAAAAAAAEAKgEBFwAAAAYAAABTdGF0dXMBAcUL" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA1YIkKAgAAAAEACgAAAFNjYW5BY3RpdmUB" +
           "AdMXAwAAAAAaAAAAVHJpZ2dlcnMgdGhlIHNjYW4gcHJvY2Vzcy4ALwA/0xcAAAAB/////wMD/////wAA" +
           "AAAEYYIKBAAAAAEACQAAAFNjYW5TdGFydAEBYRsALwEBYRthGwAAAQH/////AgAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAaMXAC4ARKMXAACWAQAAAAEAKgEBGQAAAAgAAABTZXR0aW5ncwEBwgv/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQFAGAAuAERAGAAAlgEAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABTY2FuU3RvcAEBYhsALwEBYhtiGwAAAQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> AutoIdModelVersion
        {
            get
            {
                return m_autoIdModelVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_autoIdModelVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_autoIdModelVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceInfo
        {
            get
            {
                return m_deviceInfo;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceInfo, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceInfo = value;
            }
        }

        /// <remarks />
        public LocationVariableTypeState DeviceLocation
        {
            get
            {
                return m_deviceLocation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceLocation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceLocation = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceLocationName
        {
            get
            {
                return m_deviceLocationName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceLocationName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceLocationName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceName
        {
            get
            {
                return m_deviceName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceName = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DeviceStatusEnumeration> DeviceStatus
        {
            get
            {
                return m_deviceStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceStatus = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Diagnostics
        {
            get
            {
                return m_diagnostics;
            }

            set
            {
                if (!Object.ReferenceEquals(m_diagnostics, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_diagnostics = value;
            }
        }

        /// <remarks />
        public GetDeviceLocationMethodState GetDeviceLocation
        {
            get
            {
                return m_getDeviceLocationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getDeviceLocationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getDeviceLocationMethod = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState IOData
        {
            get
            {
                return m_iOData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iOData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iOData = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState LastScanData
        {
            get
            {
                return m_lastScanData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastScanData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastScanData = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DateTime> LastScanTimestamp
        {
            get
            {
                return m_lastScanTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastScanTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastScanTimestamp = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState RuntimeParameters
        {
            get
            {
                return m_runtimeParameters;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runtimeParameters, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runtimeParameters = value;
            }
        }

        /// <remarks />
        public ScanMethodState Scan
        {
            get
            {
                return m_scanMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> ScanActive
        {
            get
            {
                return m_scanActive;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanActive, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanActive = value;
            }
        }

        /// <remarks />
        public ScanStartMethodState ScanStart
        {
            get
            {
                return m_scanStartMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanStartMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanStartMethod = value;
            }
        }

        /// <remarks />
        public MethodState ScanStop
        {
            get
            {
                return m_scanStopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scanStopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scanStopMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_autoIdModelVersion != null)
            {
                children.Add(m_autoIdModelVersion);
            }

            if (m_deviceInfo != null)
            {
                children.Add(m_deviceInfo);
            }

            if (m_deviceLocation != null)
            {
                children.Add(m_deviceLocation);
            }

            if (m_deviceLocationName != null)
            {
                children.Add(m_deviceLocationName);
            }

            if (m_deviceName != null)
            {
                children.Add(m_deviceName);
            }

            if (m_deviceStatus != null)
            {
                children.Add(m_deviceStatus);
            }

            if (m_diagnostics != null)
            {
                children.Add(m_diagnostics);
            }

            if (m_getDeviceLocationMethod != null)
            {
                children.Add(m_getDeviceLocationMethod);
            }

            if (m_iOData != null)
            {
                children.Add(m_iOData);
            }

            if (m_lastScanData != null)
            {
                children.Add(m_lastScanData);
            }

            if (m_lastScanTimestamp != null)
            {
                children.Add(m_lastScanTimestamp);
            }

            if (m_runtimeParameters != null)
            {
                children.Add(m_runtimeParameters);
            }

            if (m_scanMethod != null)
            {
                children.Add(m_scanMethod);
            }

            if (m_scanActive != null)
            {
                children.Add(m_scanActive);
            }

            if (m_scanStartMethod != null)
            {
                children.Add(m_scanStartMethod);
            }

            if (m_scanStopMethod != null)
            {
                children.Add(m_scanStopMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.AutoIdModelVersion:
                {
                    if (createOrReplace)
                    {
                        if (AutoIdModelVersion == null)
                        {
                            if (replacement == null)
                            {
                                AutoIdModelVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                AutoIdModelVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AutoIdModelVersion;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.DeviceInfo:
                {
                    if (createOrReplace)
                    {
                        if (DeviceInfo == null)
                        {
                            if (replacement == null)
                            {
                                DeviceInfo = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceInfo = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceInfo;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.DeviceLocation:
                {
                    if (createOrReplace)
                    {
                        if (DeviceLocation == null)
                        {
                            if (replacement == null)
                            {
                                DeviceLocation = new LocationVariableTypeState(this);
                            }
                            else
                            {
                                DeviceLocation = (LocationVariableTypeState)replacement;
                            }
                        }
                    }

                    instance = DeviceLocation;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.DeviceLocationName:
                {
                    if (createOrReplace)
                    {
                        if (DeviceLocationName == null)
                        {
                            if (replacement == null)
                            {
                                DeviceLocationName = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceLocationName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceLocationName;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.DeviceName:
                {
                    if (createOrReplace)
                    {
                        if (DeviceName == null)
                        {
                            if (replacement == null)
                            {
                                DeviceName = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceName;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.DeviceStatus:
                {
                    if (createOrReplace)
                    {
                        if (DeviceStatus == null)
                        {
                            if (replacement == null)
                            {
                                DeviceStatus = new BaseDataVariableState<DeviceStatusEnumeration>(this);
                            }
                            else
                            {
                                DeviceStatus = (BaseDataVariableState<DeviceStatusEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceStatus;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.Diagnostics:
                {
                    if (createOrReplace)
                    {
                        if (Diagnostics == null)
                        {
                            if (replacement == null)
                            {
                                Diagnostics = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Diagnostics = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Diagnostics;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.GetDeviceLocation:
                {
                    if (createOrReplace)
                    {
                        if (GetDeviceLocation == null)
                        {
                            if (replacement == null)
                            {
                                GetDeviceLocation = new GetDeviceLocationMethodState(this);
                            }
                            else
                            {
                                GetDeviceLocation = (GetDeviceLocationMethodState)replacement;
                            }
                        }
                    }

                    instance = GetDeviceLocation;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.IOData:
                {
                    if (createOrReplace)
                    {
                        if (IOData == null)
                        {
                            if (replacement == null)
                            {
                                IOData = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                IOData = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = IOData;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LastScanData:
                {
                    if (createOrReplace)
                    {
                        if (LastScanData == null)
                        {
                            if (replacement == null)
                            {
                                LastScanData = new BaseDataVariableState(this);
                            }
                            else
                            {
                                LastScanData = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = LastScanData;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LastScanTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastScanTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastScanTimestamp = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                LastScanTimestamp = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastScanTimestamp;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.RuntimeParameters:
                {
                    if (createOrReplace)
                    {
                        if (RuntimeParameters == null)
                        {
                            if (replacement == null)
                            {
                                RuntimeParameters = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                RuntimeParameters = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = RuntimeParameters;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.Scan:
                {
                    if (createOrReplace)
                    {
                        if (Scan == null)
                        {
                            if (replacement == null)
                            {
                                Scan = new ScanMethodState(this);
                            }
                            else
                            {
                                Scan = (ScanMethodState)replacement;
                            }
                        }
                    }

                    instance = Scan;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.ScanActive:
                {
                    if (createOrReplace)
                    {
                        if (ScanActive == null)
                        {
                            if (replacement == null)
                            {
                                ScanActive = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                ScanActive = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = ScanActive;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.ScanStart:
                {
                    if (createOrReplace)
                    {
                        if (ScanStart == null)
                        {
                            if (replacement == null)
                            {
                                ScanStart = new ScanStartMethodState(this);
                            }
                            else
                            {
                                ScanStart = (ScanStartMethodState)replacement;
                            }
                        }
                    }

                    instance = ScanStart;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.ScanStop:
                {
                    if (createOrReplace)
                    {
                        if (ScanStop == null)
                        {
                            if (replacement == null)
                            {
                                ScanStop = new MethodState(this);
                            }
                            else
                            {
                                ScanStop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ScanStop;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_autoIdModelVersion;
        private PropertyState<string> m_deviceInfo;
        private LocationVariableTypeState m_deviceLocation;
        private PropertyState<string> m_deviceLocationName;
        private PropertyState<string> m_deviceName;
        private BaseDataVariableState<DeviceStatusEnumeration> m_deviceStatus;
        private FunctionalGroupTypeState m_diagnostics;
        private GetDeviceLocationMethodState m_getDeviceLocationMethod;
        private FunctionalGroupTypeState m_iOData;
        private BaseDataVariableState m_lastScanData;
        private BaseDataVariableState<DateTime> m_lastScanTimestamp;
        private FunctionalGroupTypeState m_runtimeParameters;
        private ScanMethodState m_scanMethod;
        private BaseDataVariableState<bool> m_scanActive;
        private ScanStartMethodState m_scanStartMethod;
        private MethodState m_scanStopMethod;
        #endregion
    }
    #endif
    #endregion

    #region OcrReaderDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_OcrReaderDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OcrReaderDeviceTypeState : AutoIdDeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public OcrReaderDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OcrReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Images != null)
            {
                Images.Initialize(context, Images_InitializationString);
            }

            if (RuntimeParameters != null)
            {
                RuntimeParameters.Initialize(context, RuntimeParameters_InitializationString);
            }

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }
        }

        #region Initialization String
        private const string Images_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAGAAAASW1hZ2VzAQGOEwAvAD2OEwAA/////wEA" +
           "AAAEYMAKAQAAAAkAAABJbWFnZU5hbWUBAAsAAAA8SW1hZ2VOYW1lPgEBnRMAIwEANy2dEwAA/////woA" +
           "AAA1YIkKAgAAAAAABAAAAFNpemUBAcIXAwAAAAAeAAAAVGhlIHNpemUgb2YgdGhlIGZpbGUgaW4gYnl0" +
           "ZXMuAC4ARMIXAAAACf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABXcml0YWJsZQEBxBcDAAAAAB0A" +
           "AABXaGV0aGVyIHRoZSBmaWxlIGlzIHdyaXRhYmxlLgAuAETEFwAAAAH/////AQH/////AAAAADVgiQoC" +
           "AAAAAAAMAAAAVXNlcldyaXRhYmxlAQHDFwMAAAAAMQAAAFdoZXRoZXIgdGhlIGZpbGUgaXMgd3JpdGFi" +
           "bGUgYnkgdGhlIGN1cnJlbnQgdXNlci4ALgBEwxcAAAAB/////wEB/////wAAAAA1YIkKAgAAAAAACQAA" +
           "AE9wZW5Db3VudAEBvhcDAAAAACgAAABUaGUgY3VycmVudCBudW1iZXIgb2Ygb3BlbiBmaWxlIGhhbmRs" +
           "ZXMuAC4ARL4XAAAABf////8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQFrGwAvAQA8LWsbAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuxcALgBEuxcAAJYBAAAAAQAqAQET" +
           "AAAABAAAAE1vZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAb0XAC4ARL0XAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAWMbAC8B" +
           "AD8tYxsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG4FwAuAES4FwAAlgEA" +
           "AAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAAABAAAAFJlYWQBAWwbAC8BAEEtbBsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG/FwAuAES/FwAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAA" +
           "AAAAAQAqAQEVAAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBwBcALgBEwBcAAJYBAAAAAQAqAQETAAAABAAAAERh" +
           "dGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEB" +
           "bhsALwEARC1uGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcUXAC4ARMUX" +
           "AACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdldFBvc2l0aW9u" +
           "AQFkGwAvAQBGLWQbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuRcALgBE" +
           "uRcAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAAB" +
           "Af////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAboXAC4ARLoXAACWAQAAAAEAKgEB" +
           "FwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAAACwAAAFNldFBvc2l0aW9uAQFtGwAvAQBJLW0bAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBwRcALgBEwRcAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAA" +
           "AAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";

        private const string RuntimeParameters_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQARAAAAUnVudGltZVBhcmFtZXRlcnMBAbMTAC8B" +
           "Au0DsxMAAP////8CAAAANWCJCgIAAAABAAkAAABNYXRjaENvZGUBAfYXAwAAAAAkAAAAVGFyZ2V0IHZh" +
           "bHVlIGZvciAyRCBvciBPQ1IgZGVjb2RpbmcuAC8AP/YXAAAADP////8DA/////8AAAAANWCJCgIAAAAB" +
           "AAwAAABUZW1wbGF0ZU5hbWUBAfUXAwAAAAA/AAAAQWN0aXZhdGUgdGVtcGxhdGUgd2hpY2ggZGVmaW5l" +
           "cyBhIHNwZWNpZmljIGlkZW50aWZpY2F0aW9uIHRhc2suAC8AP/UXAAAADP////8DA/////8AAAAA";

        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBWRsALwEBYBtZGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYsXAC4ARIsXAACWAQAAAAEAKgEBGQAAAAgA" +
           "AABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQF/FwAuAER/FwAAlgIAAAABACoBARgAAAAHAAAAUmVzdWx0cwEBugsB" +
           "AAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAA";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAT2NyUmVhZGVyRGV2aWNlVHlwZUluc3Rh" +
           "bmNlAQHqAwEB6gPqAwAAAQAAAAApAAEB7QMOAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAXMX" +
           "AwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4A" +
           "RHMXAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBdBcDAAAAABgAAABNb2RlbCBu" +
           "YW1lIG9mIHRoZSBkZXZpY2UALgBEdBcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3" +
           "YXJlUmV2aXNpb24BAXgXAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBEeBcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BAXcXAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBEdxcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9u" +
           "AQF2FwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAER2FwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQF1FwMAAAAAWgAAAEFkZHJlc3Mg" +
           "KHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2Vy" +
           "IG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAER1FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAA" +
           "U2VyaWFsTnVtYmVyAQFxFwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVz" +
           "LCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARHEXAAAADP////8BAf//" +
           "//8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAXIXAwAAAABpAAAAQW4gaW5jcmVtZW50" +
           "YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdp" +
           "dGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARHIXAAAABv////8BAf////8AAAAAFWCp" +
           "CgIAAAABABIAAABBdXRvSWRNb2RlbFZlcnNpb24BATEYAC4ARDEYAAAMBAAAADEuMDEADP////8DA///" +
           "//8AAAAANWCJCgIAAAABAAoAAABEZXZpY2VOYW1lAQHsFwMAAAAAbwAAAERlZmF1bHQgY291bGQgYmUg" +
           "YWxzbyBob3N0IG5hbWUsIElQIGFkZHJlc3Mgb3IgTUFDLiBUaGlzIHNob3VsZCBiZSBhIGZpZWxkIHRo" +
           "YXQgY2FuIGJlIGNvbmZpZ3VyZWQgZm9yIGEgZGV2aWNlLgAuAETsFwAAAAz/////AwP/////AAAAABVg" +
           "iQoCAAAAAQAMAAAARGV2aWNlU3RhdHVzAQGOFwAvAD+OFwAAAQG7C/////8BAf////8AAAAABGCACgEA" +
           "AAABABEAAABSdW50aW1lUGFyYW1ldGVycwEBsxMALwEC7QOzEwAA/////wIAAAA1YIkKAgAAAAEACQAA" +
           "AE1hdGNoQ29kZQEB9hcDAAAAACQAAABUYXJnZXQgdmFsdWUgZm9yIDJEIG9yIE9DUiBkZWNvZGluZy4A" +
           "LwA/9hcAAAAM/////wMD/////wAAAAA1YIkKAgAAAAEADAAAAFRlbXBsYXRlTmFtZQEB9RcDAAAAAD8A" +
           "AABBY3RpdmF0ZSB0ZW1wbGF0ZSB3aGljaCBkZWZpbmVzIGEgc3BlY2lmaWMgaWRlbnRpZmljYXRpb24g" +
           "dGFzay4ALwA/9RcAAAAM/////wMD/////wAAAAAEYYIKBAAAAAEABAAAAFNjYW4BAVkbAC8BAWAbWRsA" +
           "AAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGLFwAuAESLFwAAlgEAAAABACoB" +
           "ARkAAAAIAAAAU2V0dGluZ3MBAcIL/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBfxcALgBEfxcAAJYCAAAAAQAqAQEYAAAABwAAAFJlc3Vs" +
           "dHMBAboLAQAAAAAAAAAAAQAqAQEXAAAABgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAAC" +
           "AAAAAQH/////AAAAAARggAoBAAAAAQAGAAAASW1hZ2VzAQGOEwAvAD2OEwAA/////wEAAAAEYMAKAQAA" +
           "AAkAAABJbWFnZU5hbWUBAAsAAAA8SW1hZ2VOYW1lPgEBnRMAIwEANy2dEwAA/////woAAAA1YIkKAgAA" +
           "AAAABAAAAFNpemUBAcIXAwAAAAAeAAAAVGhlIHNpemUgb2YgdGhlIGZpbGUgaW4gYnl0ZXMuAC4ARMIX" +
           "AAAACf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABXcml0YWJsZQEBxBcDAAAAAB0AAABXaGV0aGVy" +
           "IHRoZSBmaWxlIGlzIHdyaXRhYmxlLgAuAETEFwAAAAH/////AQH/////AAAAADVgiQoCAAAAAAAMAAAA" +
           "VXNlcldyaXRhYmxlAQHDFwMAAAAAMQAAAFdoZXRoZXIgdGhlIGZpbGUgaXMgd3JpdGFibGUgYnkgdGhl" +
           "IGN1cnJlbnQgdXNlci4ALgBEwxcAAAAB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAE9wZW5Db3Vu" +
           "dAEBvhcDAAAAACgAAABUaGUgY3VycmVudCBudW1iZXIgb2Ygb3BlbiBmaWxlIGhhbmRsZXMuAC4ARL4X" +
           "AAAABf////8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQFrGwAvAQA8LWsbAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuxcALgBEuxcAAJYBAAAAAQAqAQETAAAABAAAAE1v" +
           "ZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAb0XAC4ARL0XAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAAB" +
           "ACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAWMbAC8BAD8tYxsAAAEB" +
           "/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG4FwAuAES4FwAAlgEAAAABACoBARkA" +
           "AAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAAABAAAAFJlYWQBAWwbAC8BAEEtbBsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQG/FwAuAES/FwAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQEV" +
           "AAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBwBcALgBEwBcAAJYBAAAAAQAqAQETAAAABAAAAERhdGEAD/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEBbhsALwEARC1u" +
           "GwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcUXAC4ARMUXAACWAgAAAAEA" +
           "KgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdldFBvc2l0aW9uAQFkGwAvAQBG" +
           "LWQbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBuRcALgBEuRcAAJYBAAAA" +
           "AQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAboXAC4ARLoXAACWAQAAAAEAKgEBFwAAAAgAAABQ" +
           "b3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAFNl" +
           "dFBvc2l0aW9uAQFtGwAvAQBJLW0bAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBwRcALgBEwRcAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFwAA" +
           "AAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FolderState Images
        {
            get
            {
                return m_images;
            }

            set
            {
                if (!Object.ReferenceEquals(m_images, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_images = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_images != null)
            {
                children.Add(m_images);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.Images:
                {
                    if (createOrReplace)
                    {
                        if (Images == null)
                        {
                            if (replacement == null)
                            {
                                Images = new FolderState(this);
                            }
                            else
                            {
                                Images = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Images;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FolderState m_images;
        #endregion
    }
    #endif
    #endregion

    #region OpticalReaderDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_OpticalReaderDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalReaderDeviceTypeState : AutoIdDeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public OpticalReaderDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OpticalReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Images != null)
            {
                Images.Initialize(context, Images_InitializationString);
            }

            if (RuntimeParameters != null)
            {
                RuntimeParameters.Initialize(context, RuntimeParameters_InitializationString);
            }

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }
        }

        #region Initialization String
        private const string Images_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAGAAAASW1hZ2VzAQGJEwAvAD2JEwAA/////wEA" +
           "AAAEYMAKAQAAAAkAAABJbWFnZU5hbWUBAAsAAAA8SW1hZ2VOYW1lPgEBnBMAIwEANy2cEwAA/////woA" +
           "AAA1YIkKAgAAAAAABAAAAFNpemUBAXsXAwAAAAAeAAAAVGhlIHNpemUgb2YgdGhlIGZpbGUgaW4gYnl0" +
           "ZXMuAC4ARHsXAAAACf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABXcml0YWJsZQEBfRcDAAAAAB0A" +
           "AABXaGV0aGVyIHRoZSBmaWxlIGlzIHdyaXRhYmxlLgAuAER9FwAAAAH/////AQH/////AAAAADVgiQoC" +
           "AAAAAAAMAAAAVXNlcldyaXRhYmxlAQF8FwMAAAAAMQAAAFdoZXRoZXIgdGhlIGZpbGUgaXMgd3JpdGFi" +
           "bGUgYnkgdGhlIGN1cnJlbnQgdXNlci4ALgBEfBcAAAAB/////wEB/////wAAAAA1YIkKAgAAAAAACQAA" +
           "AE9wZW5Db3VudAEBdxcDAAAAACgAAABUaGUgY3VycmVudCBudW1iZXIgb2Ygb3BlbiBmaWxlIGhhbmRs" +
           "ZXMuAC4ARHcXAAAABf////8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQFcGwAvAQA8LVwbAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBdRcALgBEdRcAAJYBAAAAAQAqAQET" +
           "AAAABAAAAE1vZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAXYXAC4ARHYXAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAVobAC8B" +
           "AD8tWhsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFyFwAuAERyFwAAlgEA" +
           "AAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAAABAAAAFJlYWQBAV0bAC8BAEEtXRsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQF4FwAuAER4FwAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAA" +
           "AAAAAQAqAQEVAAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBeRcALgBEeRcAAJYBAAAAAQAqAQETAAAABAAAAERh" +
           "dGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEB" +
           "XxsALwEARC1fGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAX4XAC4ARH4X" +
           "AACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdldFBvc2l0aW9u" +
           "AQFbGwAvAQBGLVsbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBcxcALgBE" +
           "cxcAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAAB" +
           "Af////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXQXAC4ARHQXAACWAQAAAAEAKgEB" +
           "FwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAAACwAAAFNldFBvc2l0aW9uAQFeGwAvAQBJLV4bAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBehcALgBEehcAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAA" +
           "AAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";

        private const string RuntimeParameters_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQARAAAAUnVudGltZVBhcmFtZXRlcnMBAbUTAC8B" +
           "Au0DtRMAAP////8CAAAANWCJCgIAAAABAAkAAABNYXRjaENvZGUBAfgXAwAAAAAkAAAAVGFyZ2V0IHZh" +
           "bHVlIGZvciAyRCBvciBPQ1IgZGVjb2RpbmcuAC8AP/gXAAAADP////8DA/////8AAAAANWCJCgIAAAAB" +
           "AAwAAABUZW1wbGF0ZU5hbWUBAfcXAwAAAAA/AAAAQWN0aXZhdGUgdGVtcGxhdGUgd2hpY2ggZGVmaW5l" +
           "cyBhIHNwZWNpZmljIGlkZW50aWZpY2F0aW9uIHRhc2suAC8AP/cXAAAADP////8DA/////8AAAAA";

        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBgxsALwEBYBuDGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAYAC4ARAAYAACWAQAAAAEAKgEBGQAAAAgA" +
           "AABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQEBGAAuAEQBGAAAlgIAAAABACoBARgAAAAHAAAAUmVzdWx0cwEB0gsB" +
           "AAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAA";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAfAAAAT3B0aWNhbFJlYWRlckRldmljZVR5cGVJ" +
           "bnN0YW5jZQEB8AMBAfAD8AMAAAEAAAAAKQABAfEDDgAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVy" +
           "AQFzFwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmlj" +
           "ZQAuAERzFwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAXQXAwAAAAAYAAAATW9k" +
           "ZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARHQXAAAAFf////8BAf////8AAAAANWCJCgIAAAACABAAAABI" +
           "YXJkd2FyZVJldmlzaW9uAQF4FwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARHgXAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJl" +
           "dmlzaW9uAQF3FwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARHcXAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZp" +
           "c2lvbgEBdhcDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEdhcA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBdRcDAAAAAFoAAABBZGRy" +
           "ZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2Yg" +
           "dXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEdRcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "DAAAAFNlcmlhbE51bWJlcgEBcRcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRp" +
           "Zmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERxFwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFyFwMAAAAAaQAAAEFuIGluY3Jl" +
           "bWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0" +
           "YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERyFwAAAAb/////AQH/////AAAA" +
           "ABVgqQoCAAAAAQASAAAAQXV0b0lkTW9kZWxWZXJzaW9uAQExGAAuAEQxGAAADAQAAAAxLjAxAAz/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAKAAAARGV2aWNlTmFtZQEB7BcDAAAAAG8AAABEZWZhdWx0IGNvdWxk" +
           "IGJlIGFsc28gaG9zdCBuYW1lLCBJUCBhZGRyZXNzIG9yIE1BQy4gVGhpcyBzaG91bGQgYmUgYSBmaWVs" +
           "ZCB0aGF0IGNhbiBiZSBjb25maWd1cmVkIGZvciBhIGRldmljZS4ALgBE7BcAAAAM/////wMD/////wAA" +
           "AAAVYIkKAgAAAAEADAAAAERldmljZVN0YXR1cwEBjhcALwA/jhcAAAEBuwv/////AQH/////AAAAAARg" +
           "gAoBAAAAAQARAAAAUnVudGltZVBhcmFtZXRlcnMBAbUTAC8BAu0DtRMAAP////8CAAAANWCJCgIAAAAB" +
           "AAkAAABNYXRjaENvZGUBAfgXAwAAAAAkAAAAVGFyZ2V0IHZhbHVlIGZvciAyRCBvciBPQ1IgZGVjb2Rp" +
           "bmcuAC8AP/gXAAAADP////8DA/////8AAAAANWCJCgIAAAABAAwAAABUZW1wbGF0ZU5hbWUBAfcXAwAA" +
           "AAA/AAAAQWN0aXZhdGUgdGVtcGxhdGUgd2hpY2ggZGVmaW5lcyBhIHNwZWNpZmljIGlkZW50aWZpY2F0" +
           "aW9uIHRhc2suAC8AP/cXAAAADP////8DA/////8AAAAABGGCCgQAAAABAAQAAABTY2FuAQGDGwAvAQFg" +
           "G4MbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBABgALgBEABgAAJYBAAAA" +
           "AQAqAQEZAAAACAAAAFNldHRpbmdzAQHCC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQEYAC4ARAEYAACWAgAAAAEAKgEBGAAAAAcAAABS" +
           "ZXN1bHRzAQHSCwEAAAAAAAAAAAEAKgEBFwAAAAYAAABTdGF0dXMBAcUL/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAgAAAAEB/////wAAAAAEYIAKAQAAAAEABgAAAEltYWdlcwEBiRMALwA9iRMAAP////8BAAAABGDA" +
           "CgEAAAAJAAAASW1hZ2VOYW1lAQALAAAAPEltYWdlTmFtZT4BAZwTACMBADctnBMAAP////8KAAAANWCJ" +
           "CgIAAAAAAAQAAABTaXplAQF7FwMAAAAAHgAAAFRoZSBzaXplIG9mIHRoZSBmaWxlIGluIGJ5dGVzLgAu" +
           "AER7FwAAAAn/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAV3JpdGFibGUBAX0XAwAAAAAdAAAAV2hl" +
           "dGhlciB0aGUgZmlsZSBpcyB3cml0YWJsZS4ALgBEfRcAAAAB/////wEB/////wAAAAA1YIkKAgAAAAAA" +
           "DAAAAFVzZXJXcml0YWJsZQEBfBcDAAAAADEAAABXaGV0aGVyIHRoZSBmaWxlIGlzIHdyaXRhYmxlIGJ5" +
           "IHRoZSBjdXJyZW50IHVzZXIuAC4ARHwXAAAAAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABPcGVu" +
           "Q291bnQBAXcXAwAAAAAoAAAAVGhlIGN1cnJlbnQgbnVtYmVyIG9mIG9wZW4gZmlsZSBoYW5kbGVzLgAu" +
           "AER3FwAAAAX/////AQH/////AAAAAARhggoEAAAAAAAEAAAAT3BlbgEBXBsALwEAPC1cGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXUXAC4ARHUXAACWAQAAAAEAKgEBEwAAAAQA" +
           "AABNb2RlAAP/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQF2FwAuAER2FwAAlgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAAABQAAAENsb3NlAQFaGwAvAQA/LVob" +
           "AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBchcALgBEchcAAJYBAAAAAQAq" +
           "AQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGC" +
           "CgQAAAAAAAQAAABSZWFkAQFdGwAvAQBBLV0bAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBeBcALgBEeBcAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEA" +
           "KgEBFQAAAAYAAABMZW5ndGgABv////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXkXAC4ARHkXAACWAQAAAAEAKgEBEwAAAAQAAABEYXRhAA//" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAV3JpdGUBAV8bAC8B" +
           "AEQtXxsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF+FwAuAER+FwAAlgIA" +
           "AAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQETAAAABAAAAERhdGEAD/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAABGGCCgQAAAAAAAsAAABHZXRQb3NpdGlvbgEBWxsA" +
           "LwEARi1bGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXMXAC4ARHMXAACW" +
           "AQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQF0FwAuAER0FwAAlgEAAAABACoBARcAAAAI" +
           "AAAAUG9zaXRpb24ACf////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAsA" +
           "AABTZXRQb3NpdGlvbgEBXhsALwEASS1eGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAXoXAC4ARHoXAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoB" +
           "ARcAAAAIAAAAUG9zaXRpb24ACf////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FolderState Images
        {
            get
            {
                return m_images;
            }

            set
            {
                if (!Object.ReferenceEquals(m_images, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_images = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_images != null)
            {
                children.Add(m_images);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.Images:
                {
                    if (createOrReplace)
                    {
                        if (Images == null)
                        {
                            if (replacement == null)
                            {
                                Images = new FolderState(this);
                            }
                            else
                            {
                                Images = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Images;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FolderState m_images;
        #endregion
    }
    #endif
    #endregion

    #region OpticalVerifierDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_OpticalVerifierDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalVerifierDeviceTypeState : OpticalReaderDeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public OpticalVerifierDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.OpticalVerifierDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }
        }

        #region Initialization String
        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBjhsALwEBYBuOGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8XAC4ARI8XAACWAQAAAAEAKgEBGQAAAAgA" +
           "AABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQG8FwAuAES8FwAAlgIAAAABACoBARgAAAAHAAAAUmVzdWx0cwEB0wsB" +
           "AAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAA";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAhAAAAT3B0aWNhbFZlcmlmaWVyRGV2aWNlVHlw" +
           "ZUluc3RhbmNlAQHzAwEB8wPzAwAAAQAAAAApAAEB9QMMAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAXMXAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2" +
           "aWNlAC4ARHMXAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBdBcDAAAAABgAAABN" +
           "b2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEdBcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AEhhcmR3YXJlUmV2aXNpb24BAXgXAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJl" +
           "IG9mIHRoZSBkZXZpY2UALgBEeBcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJl" +
           "UmV2aXNpb24BAXcXAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJl" +
           "IG9mIHRoZSBkZXZpY2UALgBEdxcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJl" +
           "dmlzaW9uAQF2FwMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAER2" +
           "FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQF1FwMAAAAAWgAAAEFk" +
           "ZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBv" +
           "ZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAER1FwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAMAAAAU2VyaWFsTnVtYmVyAQFxFwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVu" +
           "dGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARHEXAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAXIXAwAAAABpAAAAQW4gaW5j" +
           "cmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBk" +
           "YXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARHIXAAAABv////8BAf////8A" +
           "AAAAFWCpCgIAAAABABIAAABBdXRvSWRNb2RlbFZlcnNpb24BATEYAC4ARDEYAAAMBAAAADEuMDEADP//" +
           "//8DA/////8AAAAANWCJCgIAAAABAAoAAABEZXZpY2VOYW1lAQHsFwMAAAAAbwAAAERlZmF1bHQgY291" +
           "bGQgYmUgYWxzbyBob3N0IG5hbWUsIElQIGFkZHJlc3Mgb3IgTUFDLiBUaGlzIHNob3VsZCBiZSBhIGZp" +
           "ZWxkIHRoYXQgY2FuIGJlIGNvbmZpZ3VyZWQgZm9yIGEgZGV2aWNlLgAuAETsFwAAAAz/////AwP/////" +
           "AAAAABVgiQoCAAAAAQAMAAAARGV2aWNlU3RhdHVzAQGOFwAvAD+OFwAAAQG7C/////8BAf////8AAAAA" +
           "BGGCCgQAAAABAAQAAABTY2FuAQGOGwAvAQFgG44bAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBjxcALgBEjxcAAJYBAAAAAQAqAQEZAAAACAAAAFNldHRpbmdzAQHCC/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAbwX" +
           "AC4ARLwXAACWAgAAAAEAKgEBGAAAAAcAAABSZXN1bHRzAQHTCwEAAAAAAAAAAAEAKgEBFwAAAAYAAABT" +
           "dGF0dXMBAcUL/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RfidReaderDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_RfidReaderDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RfidReaderDeviceTypeState : AutoIdDeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public RfidReaderDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.RfidReaderDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (AntennaNames != null)
            {
                AntennaNames.Initialize(context, AntennaNames_InitializationString);
            }

            if (Diagnostics != null)
            {
                Diagnostics.Initialize(context, Diagnostics_InitializationString);
            }

            if (KillTag != null)
            {
                KillTag.Initialize(context, KillTag_InitializationString);
            }

            if (LastScanAntenna != null)
            {
                LastScanAntenna.Initialize(context, LastScanAntenna_InitializationString);
            }

            if (LastScanRSSI != null)
            {
                LastScanRSSI.Initialize(context, LastScanRSSI_InitializationString);
            }

            if (LockTag != null)
            {
                LockTag.Initialize(context, LockTag_InitializationString);
            }

            if (ReadTag != null)
            {
                ReadTag.Initialize(context, ReadTag_InitializationString);
            }

            if (RuntimeParameters != null)
            {
                RuntimeParameters.Initialize(context, RuntimeParameters_InitializationString);
            }

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }

            if (SetTagPassword != null)
            {
                SetTagPassword.Initialize(context, SetTagPassword_InitializationString);
            }

            if (WriteTag != null)
            {
                WriteTag.Initialize(context, WriteTag_InitializationString);
            }

            if (WriteTagID != null)
            {
                WriteTagID.Initialize(context, WriteTagID_InitializationString);
            }
        }

        #region Initialization String
        private const string AntennaNames_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQAMAAAAQW50ZW5uYU5hbWVzAQGgFwAuAESgFwAA" +
           "AQHDCwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string Diagnostics_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQALAAAARGlhZ25vc3RpY3MBAa4TAwAAAAAkAAAA" +
           "RGlhZ25vc3RpYyBkYXRhIGZyb20gQXV0b0lEIERldmljZXMuAC8BAu0DrhMAAP////8BAAAAJGCACgEA" +
           "AAABAAoAAABMYXN0QWNjZXNzAQGvEwMAAAAALAAAAFZhbHVlcyBvZiB0aGUgbGFzdCBBdXRvSUQgSWRl" +
           "bnRpZmllciBhY2Nlc3MuAC8BAu0DrxMAAP////8GAAAANWCJCgIAAAABAAcAAABBbnRlbm5hAQHiFwMA" +
           "AAAAQQAAAFRoZSBhbnRlbm5hIGJ5IHdoaWNoIHRoZSB0cmFuc3BvbmRlciB3YXMgYWNjZXNzZWQgYnkg" +
           "dGhlIGNvbW1hbmQuAC8AP+IXAAAABv////8DA/////8AAAAANWCJCgIAAAABABEAAABDdXJyZW50UG93" +
           "ZXJMZXZlbAEB4xcDAAAAAEcAAABUaGUgcG93ZXIgbGV2ZWwgd2l0aCB3aGljaCB0aGUgdHJhbnNwb25k" +
           "ZXIgd2FzIGFjY2Vzc2VkIGJ5IHRoZSBjb21tYW5kLgAvAD/jFwAAAAb/////AwP/////AAAAADVgiQoC" +
           "AAAAAQACAAAAUEMBAeQXAwAAAABFAAAAVGhlIFByb3RvY29sIENvbnRyb2wgV29yZCBvZiB0aGUgdHJh" +
           "bnNwb25kZXIgYWNjZXNzZWQgYnkgdGhlIGNvbW1hbmQuAC8AP+QXAAAABf////8DA/////8AAAAANWCJ" +
           "CgIAAAABAAwAAABQb2xhcml6YXRpb24BAeUXAwAAAABNAAAAVGhlIHBvbGFyaXphdGlvbiB3aXRoIHdo" +
           "aWNoIHRoZSBsYXN0IHRyYW5zcG9uZGVyIHdhcyBhY2Nlc3NlZCBieSB0aGUgY29tbWFuZC4ALwA/5RcA" +
           "AAAM/////wMD/////wAAAAA1YIkKAgAAAAEABgAAAFJXRGF0YQEB4RcDAAAAAFcAAABUaGUgdXNlciBk" +
           "YXRhIHdoaWNoIHdhcyB3cml0dGVuIHRvIC8gd2FzIHJlYWQgZnJvbSB0aGUgUmZpZCBUcmFuc3BvbmRl" +
           "ciBieSB0aGUgY29tbWFuZC4ALwA/4RcAAAAY/////wMD/////wAAAAA1YIkKAgAAAAEACAAAAFN0cmVu" +
           "Z3RoAQHmFwMAAAAARgAAAFRoZSBSc3NpIHZhbHVlIHdpdGggd2hpY2ggdGhlIHRyYW5zcG9uZGVyIHdh" +
           "cyBhY2Nlc3NlZCBieSB0aGUgY29tbWFuZC4ALwA/5hcAAAAG/////wMD/////wAAAAA=";

        private const string KillTag_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAHAAAAS2lsbFRhZwEBaRsALwEBaRtpGwAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAa4XAC4ARK4XAACWAwAAAAEAKgEBGwAA" +
           "AAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAA" +
           "AAABACoBARsAAAAMAAAAS2lsbFBhc3N3b3JkAA//////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGvFwAuAESvFwAAlgEAAAABACoBARcAAAAG" +
           "AAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string LastScanAntenna_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAPAAAATGFzdFNjYW5BbnRlbm5hAQHRFwMAAAAA" +
           "RAAAAElEIG9mIHRoZSBhbnRlbm5hIHdpdGggd2hpY2ggdGhlIGxhc3QgQXV0b0lEIElkZW50aWZpZXIg" +
           "d2FzIHNjYW5uZWQuAC8AP9EXAAAABv////8DA/////8AAAAA";

        private const string LastScanRSSI_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAMAAAATGFzdFNjYW5SU1NJAQHSFwMAAAAAPQAA" +
           "AFJTU0kgVmFsdWUgd2l0aCB3aGljaCB0aGUgbGFzdCBBdXRvSUQgSWRlbnRpZmllciB3YXMgc2Nhbm5l" +
           "ZC4ALwA/0hcAAAAG/////wMD/////wAAAAA=";

        private const string LockTag_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAHAAAATG9ja1RhZwEBahsALwEBahtqGwAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbAXAC4ARLAXAACWBwAAAAEAKgEBGwAA" +
           "AAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAA" +
           "AAABACoBARcAAAAIAAAAUGFzc3dvcmQAD/////8AAAAAAAEAKgEBFwAAAAYAAABSZWdpb24BAccL////" +
           "/wAAAAAAAQAqAQEVAAAABAAAAExvY2sBAcgL/////wAAAAAAAQAqAQEVAAAABgAAAE9mZnNldAAH////" +
           "/wAAAAAAAQAqAQEVAAAABgAAAExlbmd0aAAH/////wAAAAAAAQAoAQEAAAABAAAABwAAAAEB/////wAA" +
           "AAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBsRcALgBEsRcAAJYBAAAAAQAqAQEXAAAABgAA" +
           "AFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string ReadTag_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAHAAAAUmVhZFRhZwEBZhsALwEBZhtmGwAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaYXAC4ARKYXAACWBgAAAAEAKgEBGwAA" +
           "AAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAA" +
           "AAABACoBARUAAAAGAAAAUmVnaW9uAAX/////AAAAAAABACoBARUAAAAGAAAAT2Zmc2V0AAf/////AAAA" +
           "AAABACoBARUAAAAGAAAATGVuZ3RoAAf/////AAAAAAABACoBARcAAAAIAAAAUGFzc3dvcmQAD/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAYAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AagXAC4ARKgXAACWAgAAAAEAKgEBGQAAAAoAAABSZXN1bHREYXRhAA//////AAAAAAABACoBARcAAAAG" +
           "AAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAA";

        private const string RuntimeParameters_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQARAAAAUnVudGltZVBhcmFtZXRlcnMBAbITAC8B" +
           "Au0DshMAAP////8FAAAAN2CJCgIAAAABAA8AAABDb2RlVHlwZXNSV0RhdGEBAecXAwAAAABLAAAAU3Vw" +
           "cG9ydGVkIENvZGVUeXBlcyBhbmQgc2VsZWN0ZWQgQ29kZVR5cGUgZm9yIHRoZSBkaWFnbm9zdGljcyB2" +
           "YWx1ZSBSV0RhdGEuAC8BAEgJ5xcAAAAHAQAAAAEAAAAAAAAAAwP/////AQAAABdgiQoCAAAAAAALAAAA" +
           "RW51bVN0cmluZ3MBAegXAC4AROgXAAAAFQEAAAABAAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAEADgAA" +
           "AEVuYWJsZUFudGVubmFzAQHuFwMAAAAAPAAAAEFudGVubmFzIHRoYXQgc2hhbGwgYmUgdXNlZCBieSB0" +
           "aGUgZGV2aWNlIGZvciBpdHMgb3BlcmF0aW9uLgAvAD/uFwAAAAf/////AwP/////AAAAADVgiQoCAAAA" +
           "AQAHAAAATWluUnNzaQEBAhgDAAAAAB0AAABMb3dlc3QgYWNjZXB0YWJsZSBSU1NJIHZhbHVlLgAvAD8C" +
           "GAAAAAb/////AwP/////AAAAADVgiQoCAAAAAQAHAAAAUmZQb3dlcgEB/RcDAAAAACgAAABSYWRpbyB0" +
           "cmFuc21pc3Npb24gcG93ZXIgb2YgdGhlIGFudGVubmEuAC8AP/0XAAAAAv////8DA/////8AAAAAN2CJ" +
           "CgIAAAABAAgAAABUYWdUeXBlcwEB6RcDAAAAACoAAABFeHBlY3RlZCB0YWdzIGluIGEgbXVsdGktdHlw" +
           "ZSBlbnZpcm9ubWVudC4ALwEASAnpFwAAAAcBAAAAAQAAAAAAAAADA/////8BAAAAF2CJCgIAAAAAAAsA" +
           "AABFbnVtU3RyaW5ncwEB7RcALgBE7RcAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBZRsALwEBYBtlGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQXAC4ARKQXAACWAQAAAAEAKgEBGAAAAAcA" +
           "AABTZXR0aW5nAQHCC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAZsXAC4ARJsXAACWAgAAAAEAKgEBGAAAAAcAAABSZXN1bHRzAQG/CwEA" +
           "AAAAAAAAAAEAKgEBFwAAAAYAAABTdGF0dXMBAcUL/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB////" +
           "/wAAAAA=";

        private const string SetTagPassword_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAOAAAAU2V0VGFnUGFzc3dvcmQBAWgbAC8BAWgb" +
           "aBsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGrFwAuAESrFwAAlgUAAAAB" +
           "ACoBARsAAAAKAAAASWRlbnRpZmllcgEBzAv/////AAAAAAABACoBARkAAAAIAAAAQ29kZVR5cGUBAdcL" +
           "/////wAAAAAAAQAqAQEdAAAADAAAAFBhc3N3b3JkVHlwZQEBxgv/////AAAAAAABACoBAR0AAAAOAAAA" +
           "QWNjZXNzUGFzc3dvcmQAD/////8AAAAAAAEAKgEBGgAAAAsAAABOZXdQYXNzd29yZAAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAABQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBrBcA" +
           "LgBErBcAAJYBAAAAAQAqAQEXAAAABgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AQH/////AAAAAA==";

        private const string WriteTag_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAIAAAAV3JpdGVUYWcBAWcbAC8BAWcbZxsAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGpFwAuAESpFwAAlgYAAAABACoBARsA" +
           "AAAKAAAASWRlbnRpZmllcgEBzAv/////AAAAAAABACoBARkAAAAIAAAAQ29kZVR5cGUBAdcL/////wAA" +
           "AAAAAQAqAQEVAAAABgAAAFJlZ2lvbgAF/////wAAAAAAAQAqAQEVAAAABgAAAE9mZnNldAAH/////wAA" +
           "AAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEAKgEBFwAAAAgAAABQYXNzd29yZAAP/////wAA" +
           "AAAAAQAoAQEAAAABAAAABgAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "qhcALgBEqhcAAJYBAAAAAQAqAQEXAAAABgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAAB" +
           "AAAAAQH/////AAAAAA==";

        private const string WriteTagID_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAKAAAAV3JpdGVUYWdJRAEBbxsALwEBbxtvGwAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfkXAC4ARPkXAACWBgAAAAEAKgEB" +
           "GwAAAAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////" +
           "AAAAAAABACoBARUAAAAGAAAATmV3VUlkAA//////AAAAAAABACoBARIAAAADAAAAQUZJAAP/////AAAA" +
           "AAABACoBARUAAAAGAAAAVG9nZ2xlAAH/////AAAAAAABACoBARcAAAAIAAAAUGFzc3dvcmQAD/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAYAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AfwXAC4ARPwXAACWAQAAAAEAKgEBFwAAAAYAAABTdGF0dXMBAcUL/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AQAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAcAAAAUmZpZFJlYWRlckRldmljZVR5cGVJbnN0" +
           "YW5jZQEB6wMBAesD6wMAAAIAAAAAKQABAfgDACkAAQHuAxcAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0" +
           "dXJlcgEBcxcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBk" +
           "ZXZpY2UALgBEcxcAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQF0FwMAAAAAGAAA" +
           "AE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAER0FwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEBeBcDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAER4FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdh" +
           "cmVSZXZpc2lvbgEBdxcDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAER3FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNl" +
           "UmV2aXNpb24BAXYXAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4A" +
           "RHYXAAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAXUXAwAAAABaAAAA" +
           "QWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3Mp" +
           "IG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARHUXAAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAACAAwAAABTZXJpYWxOdW1iZXIBAXEXAwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlk" +
           "ZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBEcRcAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBchcDAAAAAGkAAABBbiBp" +
           "bmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGlj" +
           "IGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEchcAAAAG/////wEB////" +
           "/wAAAAAVYKkKAgAAAAEAEgAAAEF1dG9JZE1vZGVsVmVyc2lvbgEBMRgALgBEMRgAAAwEAAAAMS4wMQAM" +
           "/////wMD/////wAAAAA1YIkKAgAAAAEACgAAAERldmljZU5hbWUBAewXAwAAAABvAAAARGVmYXVsdCBj" +
           "b3VsZCBiZSBhbHNvIGhvc3QgbmFtZSwgSVAgYWRkcmVzcyBvciBNQUMuIFRoaXMgc2hvdWxkIGJlIGEg" +
           "ZmllbGQgdGhhdCBjYW4gYmUgY29uZmlndXJlZCBmb3IgYSBkZXZpY2UuAC4AROwXAAAADP////8DA///" +
           "//8AAAAAFWCJCgIAAAABAAwAAABEZXZpY2VTdGF0dXMBAY4XAC8AP44XAAABAbsL/////wEB/////wAA" +
           "AAAkYIAKAQAAAAEACwAAAERpYWdub3N0aWNzAQGuEwMAAAAAJAAAAERpYWdub3N0aWMgZGF0YSBmcm9t" +
           "IEF1dG9JRCBEZXZpY2VzLgAvAQLtA64TAAD/////AQAAACRggAoBAAAAAQAKAAAATGFzdEFjY2VzcwEB" +
           "rxMDAAAAACwAAABWYWx1ZXMgb2YgdGhlIGxhc3QgQXV0b0lEIElkZW50aWZpZXIgYWNjZXNzLgAvAQLt" +
           "A68TAAD/////BgAAADVgiQoCAAAAAQAHAAAAQW50ZW5uYQEB4hcDAAAAAEEAAABUaGUgYW50ZW5uYSBi" +
           "eSB3aGljaCB0aGUgdHJhbnNwb25kZXIgd2FzIGFjY2Vzc2VkIGJ5IHRoZSBjb21tYW5kLgAvAD/iFwAA" +
           "AAb/////AwP/////AAAAADVgiQoCAAAAAQARAAAAQ3VycmVudFBvd2VyTGV2ZWwBAeMXAwAAAABHAAAA" +
           "VGhlIHBvd2VyIGxldmVsIHdpdGggd2hpY2ggdGhlIHRyYW5zcG9uZGVyIHdhcyBhY2Nlc3NlZCBieSB0" +
           "aGUgY29tbWFuZC4ALwA/4xcAAAAG/////wMD/////wAAAAA1YIkKAgAAAAEAAgAAAFBDAQHkFwMAAAAA" +
           "RQAAAFRoZSBQcm90b2NvbCBDb250cm9sIFdvcmQgb2YgdGhlIHRyYW5zcG9uZGVyIGFjY2Vzc2VkIGJ5" +
           "IHRoZSBjb21tYW5kLgAvAD/kFwAAAAX/////AwP/////AAAAADVgiQoCAAAAAQAMAAAAUG9sYXJpemF0" +
           "aW9uAQHlFwMAAAAATQAAAFRoZSBwb2xhcml6YXRpb24gd2l0aCB3aGljaCB0aGUgbGFzdCB0cmFuc3Bv" +
           "bmRlciB3YXMgYWNjZXNzZWQgYnkgdGhlIGNvbW1hbmQuAC8AP+UXAAAADP////8DA/////8AAAAANWCJ" +
           "CgIAAAABAAYAAABSV0RhdGEBAeEXAwAAAABXAAAAVGhlIHVzZXIgZGF0YSB3aGljaCB3YXMgd3JpdHRl" +
           "biB0byAvIHdhcyByZWFkIGZyb20gdGhlIFJmaWQgVHJhbnNwb25kZXIgYnkgdGhlIGNvbW1hbmQuAC8A" +
           "P+EXAAAAGP////8DA/////8AAAAANWCJCgIAAAABAAgAAABTdHJlbmd0aAEB5hcDAAAAAEYAAABUaGUg" +
           "UnNzaSB2YWx1ZSB3aXRoIHdoaWNoIHRoZSB0cmFuc3BvbmRlciB3YXMgYWNjZXNzZWQgYnkgdGhlIGNv" +
           "bW1hbmQuAC8AP+YXAAAABv////8DA/////8AAAAABGCACgEAAAABABEAAABSdW50aW1lUGFyYW1ldGVy" +
           "cwEBshMALwEC7QOyEwAA/////wUAAAA3YIkKAgAAAAEADwAAAENvZGVUeXBlc1JXRGF0YQEB5xcDAAAA" +
           "AEsAAABTdXBwb3J0ZWQgQ29kZVR5cGVzIGFuZCBzZWxlY3RlZCBDb2RlVHlwZSBmb3IgdGhlIGRpYWdu" +
           "b3N0aWNzIHZhbHVlIFJXRGF0YS4ALwEASAnnFwAAAAcBAAAAAQAAAAAAAAADA/////8BAAAAF2CJCgIA" +
           "AAAAAAsAAABFbnVtU3RyaW5ncwEB6BcALgBE6BcAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAADVgiQoC" +
           "AAAAAQAOAAAARW5hYmxlQW50ZW5uYXMBAe4XAwAAAAA8AAAAQW50ZW5uYXMgdGhhdCBzaGFsbCBiZSB1" +
           "c2VkIGJ5IHRoZSBkZXZpY2UgZm9yIGl0cyBvcGVyYXRpb24uAC8AP+4XAAAAB/////8DA/////8AAAAA" +
           "NWCJCgIAAAABAAcAAABNaW5Sc3NpAQECGAMAAAAAHQAAAExvd2VzdCBhY2NlcHRhYmxlIFJTU0kgdmFs" +
           "dWUuAC8APwIYAAAABv////8DA/////8AAAAANWCJCgIAAAABAAcAAABSZlBvd2VyAQH9FwMAAAAAKAAA" +
           "AFJhZGlvIHRyYW5zbWlzc2lvbiBwb3dlciBvZiB0aGUgYW50ZW5uYS4ALwA//RcAAAAC/////wMD////" +
           "/wAAAAA3YIkKAgAAAAEACAAAAFRhZ1R5cGVzAQHpFwMAAAAAKgAAAEV4cGVjdGVkIHRhZ3MgaW4gYSBt" +
           "dWx0aS10eXBlIGVudmlyb25tZW50LgAvAQBICekXAAAABwEAAAABAAAAAAAAAAMD/////wEAAAAXYIkK" +
           "AgAAAAAACwAAAEVudW1TdHJpbmdzAQHtFwAuAETtFwAAABUBAAAAAQAAAAAAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAQAAABTY2FuAQFlGwAvAQFgG2UbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBpBcALgBEpBcAAJYBAAAAAQAqAQEYAAAABwAAAFNldHRpbmcBAcIL/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBmxcALgBE" +
           "mxcAAJYCAAAAAQAqAQEYAAAABwAAAFJlc3VsdHMBAb8LAQAAAAAAAAAAAQAqAQEXAAAABgAAAFN0YXR1" +
           "cwEBxQv/////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAABdgiQoCAAAAAQAMAAAAQW50ZW5u" +
           "YU5hbWVzAQGgFwAuAESgFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAAEYYIKBAAAAAEABwAAAEtp" +
           "bGxUYWcBAWkbAC8BAWkbaRsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGu" +
           "FwAuAESuFwAAlgMAAAABACoBARsAAAAKAAAASWRlbnRpZmllcgEBzAv/////AAAAAAABACoBARkAAAAI" +
           "AAAAQ29kZVR5cGUBAdcL/////wAAAAAAAQAqAQEbAAAADAAAAEtpbGxQYXNzd29yZAAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAwAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBrxcA" +
           "LgBErxcAAJYBAAAAAQAqAQEXAAAABgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AQH/////AAAAADVgiQoCAAAAAQAPAAAATGFzdFNjYW5BbnRlbm5hAQHRFwMAAAAARAAAAElEIG9mIHRo" +
           "ZSBhbnRlbm5hIHdpdGggd2hpY2ggdGhlIGxhc3QgQXV0b0lEIElkZW50aWZpZXIgd2FzIHNjYW5uZWQu" +
           "AC8AP9EXAAAABv////8DA/////8AAAAANWCJCgIAAAABAAwAAABMYXN0U2NhblJTU0kBAdIXAwAAAAA9" +
           "AAAAUlNTSSBWYWx1ZSB3aXRoIHdoaWNoIHRoZSBsYXN0IEF1dG9JRCBJZGVudGlmaWVyIHdhcyBzY2Fu" +
           "bmVkLgAvAD/SFwAAAAb/////AwP/////AAAAAARhggoEAAAAAQAHAAAATG9ja1RhZwEBahsALwEBahtq" +
           "GwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbAXAC4ARLAXAACWBwAAAAEA" +
           "KgEBGwAAAAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/" +
           "////AAAAAAABACoBARcAAAAIAAAAUGFzc3dvcmQAD/////8AAAAAAAEAKgEBFwAAAAYAAABSZWdpb24B" +
           "AccL/////wAAAAAAAQAqAQEVAAAABAAAAExvY2sBAcgL/////wAAAAAAAQAqAQEVAAAABgAAAE9mZnNl" +
           "dAAH/////wAAAAAAAQAqAQEVAAAABgAAAExlbmd0aAAH/////wAAAAAAAQAoAQEAAAABAAAABwAAAAEB" +
           "/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBsRcALgBEsRcAAJYBAAAAAQAqAQEX" +
           "AAAABgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAHAAAAUmVhZFRhZwEBZhsALwEBZhtmGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAaYXAC4ARKYXAACWBgAAAAEAKgEBGwAAAAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEA" +
           "KgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAAAAABACoBARUAAAAGAAAAUmVnaW9uAAX/////AAAA" +
           "AAABACoBARUAAAAGAAAAT2Zmc2V0AAf/////AAAAAAABACoBARUAAAAGAAAATGVuZ3RoAAf/////AAAA" +
           "AAABACoBARcAAAAIAAAAUGFzc3dvcmQAD/////8AAAAAAAEAKAEBAAAAAQAAAAYAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAagXAC4ARKgXAACWAgAAAAEAKgEBGQAAAAoAAABS" +
           "ZXN1bHREYXRhAA//////AAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAIAAAABAf////8AAAAABGGCCgQAAAABAA4AAABTZXRUYWdQYXNzd29yZAEBaBsALwEBaBtoGwAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAasXAC4ARKsXAACWBQAAAAEAKgEB" +
           "GwAAAAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////" +
           "AAAAAAABACoBAR0AAAAMAAAAUGFzc3dvcmRUeXBlAQHGC/////8AAAAAAAEAKgEBHQAAAA4AAABBY2Nl" +
           "c3NQYXNzd29yZAAP/////wAAAAAAAQAqAQEaAAAACwAAAE5ld1Bhc3N3b3JkAA//////AAAAAAABACgB" +
           "AQAAAAEAAAAFAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGsFwAuAESs" +
           "FwAAlgEAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf//" +
           "//8AAAAABGGCCgQAAAABAAgAAABXcml0ZVRhZwEBZxsALwEBZxtnGwAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAakXAC4ARKkXAACWBgAAAAEAKgEBGwAAAAoAAABJZGVudGlmaWVy" +
           "AQHMC/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAAAAABACoBARUAAAAGAAAA" +
           "UmVnaW9uAAX/////AAAAAAABACoBARUAAAAGAAAAT2Zmc2V0AAf/////AAAAAAABACoBARMAAAAEAAAA" +
           "RGF0YQAP/////wAAAAAAAQAqAQEXAAAACAAAAFBhc3N3b3JkAA//////AAAAAAABACgBAQAAAAEAAAAG" +
           "AAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGqFwAuAESqFwAAlgEAAAAB" +
           "ACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAoAAABXcml0ZVRhZ0lEAQFvGwAvAQFvG28bAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEB+RcALgBE+RcAAJYGAAAAAQAqAQEbAAAACgAAAElkZW50aWZpZXIBAcwL////" +
           "/wAAAAAAAQAqAQEZAAAACAAAAENvZGVUeXBlAQHXC/////8AAAAAAAEAKgEBFQAAAAYAAABOZXdVSWQA" +
           "D/////8AAAAAAAEAKgEBEgAAAAMAAABBRkkAA/////8AAAAAAAEAKgEBFQAAAAYAAABUb2dnbGUAAf//" +
           "//8AAAAAAAEAKgEBFwAAAAgAAABQYXNzd29yZAAP/////wAAAAAAAQAoAQEAAAABAAAABgAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/BcALgBE/BcAAJYBAAAAAQAqAQEXAAAA" +
           "BgAAAFN0YXR1cwEBxQv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<AntennaNameIdPair[]> AntennaNames
        {
            get
            {
                return m_antennaNames;
            }

            set
            {
                if (!Object.ReferenceEquals(m_antennaNames, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_antennaNames = value;
            }
        }

        /// <remarks />
        public KillTagMethodState KillTag
        {
            get
            {
                return m_killTagMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_killTagMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_killTagMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> LastScanAntenna
        {
            get
            {
                return m_lastScanAntenna;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastScanAntenna, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastScanAntenna = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> LastScanRSSI
        {
            get
            {
                return m_lastScanRSSI;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastScanRSSI, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastScanRSSI = value;
            }
        }

        /// <remarks />
        public LockTagMethodState LockTag
        {
            get
            {
                return m_lockTagMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lockTagMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockTagMethod = value;
            }
        }

        /// <remarks />
        public ReadTagMethodState ReadTag
        {
            get
            {
                return m_readTagMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readTagMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readTagMethod = value;
            }
        }

        /// <remarks />
        public SetTagPasswordMethodState SetTagPassword
        {
            get
            {
                return m_setTagPasswordMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setTagPasswordMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setTagPasswordMethod = value;
            }
        }

        /// <remarks />
        public WriteTagMethodState WriteTag
        {
            get
            {
                return m_writeTagMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_writeTagMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_writeTagMethod = value;
            }
        }

        /// <remarks />
        public WriteTagIDMethodState WriteTagID
        {
            get
            {
                return m_writeTagIDMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_writeTagIDMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_writeTagIDMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_antennaNames != null)
            {
                children.Add(m_antennaNames);
            }

            if (m_killTagMethod != null)
            {
                children.Add(m_killTagMethod);
            }

            if (m_lastScanAntenna != null)
            {
                children.Add(m_lastScanAntenna);
            }

            if (m_lastScanRSSI != null)
            {
                children.Add(m_lastScanRSSI);
            }

            if (m_lockTagMethod != null)
            {
                children.Add(m_lockTagMethod);
            }

            if (m_readTagMethod != null)
            {
                children.Add(m_readTagMethod);
            }

            if (m_setTagPasswordMethod != null)
            {
                children.Add(m_setTagPasswordMethod);
            }

            if (m_writeTagMethod != null)
            {
                children.Add(m_writeTagMethod);
            }

            if (m_writeTagIDMethod != null)
            {
                children.Add(m_writeTagIDMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.AntennaNames:
                {
                    if (createOrReplace)
                    {
                        if (AntennaNames == null)
                        {
                            if (replacement == null)
                            {
                                AntennaNames = new PropertyState<AntennaNameIdPair[]>(this);
                            }
                            else
                            {
                                AntennaNames = (PropertyState<AntennaNameIdPair[]>)replacement;
                            }
                        }
                    }

                    instance = AntennaNames;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.KillTag:
                {
                    if (createOrReplace)
                    {
                        if (KillTag == null)
                        {
                            if (replacement == null)
                            {
                                KillTag = new KillTagMethodState(this);
                            }
                            else
                            {
                                KillTag = (KillTagMethodState)replacement;
                            }
                        }
                    }

                    instance = KillTag;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LastScanAntenna:
                {
                    if (createOrReplace)
                    {
                        if (LastScanAntenna == null)
                        {
                            if (replacement == null)
                            {
                                LastScanAntenna = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                LastScanAntenna = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = LastScanAntenna;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LastScanRSSI:
                {
                    if (createOrReplace)
                    {
                        if (LastScanRSSI == null)
                        {
                            if (replacement == null)
                            {
                                LastScanRSSI = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                LastScanRSSI = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = LastScanRSSI;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LockTag:
                {
                    if (createOrReplace)
                    {
                        if (LockTag == null)
                        {
                            if (replacement == null)
                            {
                                LockTag = new LockTagMethodState(this);
                            }
                            else
                            {
                                LockTag = (LockTagMethodState)replacement;
                            }
                        }
                    }

                    instance = LockTag;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.ReadTag:
                {
                    if (createOrReplace)
                    {
                        if (ReadTag == null)
                        {
                            if (replacement == null)
                            {
                                ReadTag = new ReadTagMethodState(this);
                            }
                            else
                            {
                                ReadTag = (ReadTagMethodState)replacement;
                            }
                        }
                    }

                    instance = ReadTag;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.SetTagPassword:
                {
                    if (createOrReplace)
                    {
                        if (SetTagPassword == null)
                        {
                            if (replacement == null)
                            {
                                SetTagPassword = new SetTagPasswordMethodState(this);
                            }
                            else
                            {
                                SetTagPassword = (SetTagPasswordMethodState)replacement;
                            }
                        }
                    }

                    instance = SetTagPassword;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.WriteTag:
                {
                    if (createOrReplace)
                    {
                        if (WriteTag == null)
                        {
                            if (replacement == null)
                            {
                                WriteTag = new WriteTagMethodState(this);
                            }
                            else
                            {
                                WriteTag = (WriteTagMethodState)replacement;
                            }
                        }
                    }

                    instance = WriteTag;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.WriteTagID:
                {
                    if (createOrReplace)
                    {
                        if (WriteTagID == null)
                        {
                            if (replacement == null)
                            {
                                WriteTagID = new WriteTagIDMethodState(this);
                            }
                            else
                            {
                                WriteTagID = (WriteTagIDMethodState)replacement;
                            }
                        }
                    }

                    instance = WriteTagID;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<AntennaNameIdPair[]> m_antennaNames;
        private KillTagMethodState m_killTagMethod;
        private BaseDataVariableState<int> m_lastScanAntenna;
        private BaseDataVariableState<int> m_lastScanRSSI;
        private LockTagMethodState m_lockTagMethod;
        private ReadTagMethodState m_readTagMethod;
        private SetTagPasswordMethodState m_setTagPasswordMethod;
        private WriteTagMethodState m_writeTagMethod;
        private WriteTagIDMethodState m_writeTagIDMethod;
        #endregion
    }
    #endif
    #endregion

    #region RtlsDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_RtlsDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RtlsDeviceTypeState : AutoIdDeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public RtlsDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AutoID.ObjectTypes.RtlsDeviceType, Opc.Ua.AutoID.Namespaces.AutoID, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (GetLocation != null)
            {
                GetLocation.Initialize(context, GetLocation_InitializationString);
            }

            if (GetSupportedLocationTypes != null)
            {
                GetSupportedLocationTypes.Initialize(context, GetSupportedLocationTypes_InitializationString);
            }

            if (GetUnits != null)
            {
                GetUnits.Initialize(context, GetUnits_InitializationString);
            }

            if (Scan != null)
            {
                Scan.Initialize(context, Scan_InitializationString);
            }
        }

        #region Initialization String
        private const string GetLocation_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQALAAAAR2V0TG9jYXRpb24BAZAbAC8BAZAbkBsA" +
           "AAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQGAAuAERQGAAAlgMAAAABACoB" +
           "ARsAAAAKAAAASWRlbnRpZmllcgEBzAv/////AAAAAAABACoBAR0AAAAMAAAATG9jYXRpb25UeXBlAQHB" +
           "C/////8AAAAAAAEAKgEBGQAAAAgAAABDb2RlVHlwZQEB1wv/////AAAAAAABACgBAQAAAAEAAAADAAAA" +
           "AQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFRGAAuAERRGAAAlgEAAAABACoB" +
           "ARcAAAAGAAAAUmVzdWx0AQHUC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string GetSupportedLocationTypes_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAAR2V0U3VwcG9ydGVkTG9jYXRpb25UeXBl" +
           "cwEBkhsALwEBkhuSGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFSGAAu" +
           "AERSGAAAlgEAAAABACoBAScAAAAWAAAAU3VwcG9ydGVkTG9jYXRpb25UeXBlcwEBwQsBAAAAAAAAAAAB" +
           "ACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string GetUnits_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAIAAAAR2V0VW5pdHMBAZEbAC8BAZEbkRsAAAEB" +
           "/////wAAAAA=";

        private const string Scan_InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAEAAAAU2NhbgEBjxsALwEBYBuPGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUoYAC4AREoYAACWAQAAAAEAKgEBGQAAAAgA" +
           "AABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQFLGAAuAERLGAAAlgIAAAABACoBARgAAAAHAAAAUmVzdWx0cwEB1AsB" +
           "AAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAA";

        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAWAAAAUnRsc0RldmljZVR5cGVJbnN0YW5jZQEB" +
           "9AMBAfQD9AMAAAEAAAAAKQABAfYDEwAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFzFwMAAAAA" +
           "MAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAERzFwAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAXQXAwAAAAAYAAAATW9kZWwgbmFtZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARHQXAAAAFf////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJl" +
           "dmlzaW9uAQF4FwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARHgXAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQF3" +
           "FwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARHcXAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBdhcD" +
           "AAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEdhcAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBdRcDAAAAAFoAAABBZGRyZXNzIChwYXRo" +
           "bmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51" +
           "YWwgZm9yIHRoZSBkZXZpY2UALgBEdRcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlh" +
           "bE51bWJlcgEBcRcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0" +
           "aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAERxFwAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQFyFwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNv" +
           "dW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4g" +
           "dGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAERyFwAAAAb/////AQH/////AAAAABVgqQoCAAAA" +
           "AQASAAAAQXV0b0lkTW9kZWxWZXJzaW9uAQExGAAuAEQxGAAADAQAAAAxLjAxAAz/////AwP/////AAAA" +
           "ADVgiQoCAAAAAQAKAAAARGV2aWNlTmFtZQEB7BcDAAAAAG8AAABEZWZhdWx0IGNvdWxkIGJlIGFsc28g" +
           "aG9zdCBuYW1lLCBJUCBhZGRyZXNzIG9yIE1BQy4gVGhpcyBzaG91bGQgYmUgYSBmaWVsZCB0aGF0IGNh" +
           "biBiZSBjb25maWd1cmVkIGZvciBhIGRldmljZS4ALgBE7BcAAAAM/////wMD/////wAAAAAVYIkKAgAA" +
           "AAEADAAAAERldmljZVN0YXR1cwEBjhcALwA/jhcAAAEBuwv/////AQH/////AAAAAARhggoEAAAAAQAE" +
           "AAAAU2NhbgEBjxsALwEBYBuPGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AUoYAC4AREoYAACWAQAAAAEAKgEBGQAAAAgAAABTZXR0aW5ncwEBwgv/////AAAAAAABACgBAQAAAAEA" +
           "AAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFLGAAuAERLGAAAlgIA" +
           "AAABACoBARgAAAAHAAAAUmVzdWx0cwEB1AsBAAAAAAAAAAABACoBARcAAAAGAAAAU3RhdHVzAQHFC///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCgIAAAABABAAAABHZW9ncmFwaGljYWxV" +
           "bml0AQFGGAAuAERGGAAAAQB3A/////8DA/////8AAAAABGGCCgQAAAABAAsAAABHZXRMb2NhdGlvbgEB" +
           "kBsALwEBkBuQGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVAYAC4ARFAY" +
           "AACWAwAAAAEAKgEBGwAAAAoAAABJZGVudGlmaWVyAQHMC/////8AAAAAAAEAKgEBHQAAAAwAAABMb2Nh" +
           "dGlvblR5cGUBAcEL/////wAAAAAAAQAqAQEZAAAACAAAAENvZGVUeXBlAQHXC/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAMAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVEYAC4ARFEY" +
           "AACWAQAAAAEAKgEBFwAAAAYAAABSZXN1bHQBAdQL/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEAGQAAAEdldFN1cHBvcnRlZExvY2F0aW9uVHlwZXMBAZIbAC8BAZIbkhsAAAEB" +
           "/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBUhgALgBEUhgAAJYBAAAAAQAqAQEn" +
           "AAAAFgAAAFN1cHBvcnRlZExvY2F0aW9uVHlwZXMBAcELAQAAAAAAAAAAAQAoAQEAAAABAAAAAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEACAAAAEdldFVuaXRzAQGRGwAvAQGRG5EbAAABAf////8AAAAAFWCJCgIA" +
           "AAABAAoAAABMZW5ndGhVbml0AQFJGAAuAERJGAAAAQB3A/////8DA/////8AAAAAFWCJCgIAAAABAA4A" +
           "AABSb3RhdGlvbmFsVW5pdAEBSBgALgBESBgAAAEAdwP/////AwP/////AAAAABVgiQoCAAAAAQAJAAAA" +
           "U3BlZWRVbml0AQFHGAAuAERHGAAAAQB3A/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<EUInformation> GeographicalUnit
        {
            get
            {
                return m_geographicalUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_geographicalUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_geographicalUnit = value;
            }
        }

        /// <remarks />
        public GetLocationMethodState GetLocation
        {
            get
            {
                return m_getLocationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getLocationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getLocationMethod = value;
            }
        }

        /// <remarks />
        public GetSupportedLocationTypesMethodState GetSupportedLocationTypes
        {
            get
            {
                return m_getSupportedLocationTypesMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getSupportedLocationTypesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getSupportedLocationTypesMethod = value;
            }
        }

        /// <remarks />
        public MethodState GetUnits
        {
            get
            {
                return m_getUnitsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getUnitsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getUnitsMethod = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> LengthUnit
        {
            get
            {
                return m_lengthUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lengthUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lengthUnit = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> RotationalUnit
        {
            get
            {
                return m_rotationalUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotationalUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotationalUnit = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> SpeedUnit
        {
            get
            {
                return m_speedUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speedUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speedUnit = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_geographicalUnit != null)
            {
                children.Add(m_geographicalUnit);
            }

            if (m_getLocationMethod != null)
            {
                children.Add(m_getLocationMethod);
            }

            if (m_getSupportedLocationTypesMethod != null)
            {
                children.Add(m_getSupportedLocationTypesMethod);
            }

            if (m_getUnitsMethod != null)
            {
                children.Add(m_getUnitsMethod);
            }

            if (m_lengthUnit != null)
            {
                children.Add(m_lengthUnit);
            }

            if (m_rotationalUnit != null)
            {
                children.Add(m_rotationalUnit);
            }

            if (m_speedUnit != null)
            {
                children.Add(m_speedUnit);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AutoID.BrowseNames.GeographicalUnit:
                {
                    if (createOrReplace)
                    {
                        if (GeographicalUnit == null)
                        {
                            if (replacement == null)
                            {
                                GeographicalUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                GeographicalUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = GeographicalUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.GetLocation:
                {
                    if (createOrReplace)
                    {
                        if (GetLocation == null)
                        {
                            if (replacement == null)
                            {
                                GetLocation = new GetLocationMethodState(this);
                            }
                            else
                            {
                                GetLocation = (GetLocationMethodState)replacement;
                            }
                        }
                    }

                    instance = GetLocation;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.GetSupportedLocationTypes:
                {
                    if (createOrReplace)
                    {
                        if (GetSupportedLocationTypes == null)
                        {
                            if (replacement == null)
                            {
                                GetSupportedLocationTypes = new GetSupportedLocationTypesMethodState(this);
                            }
                            else
                            {
                                GetSupportedLocationTypes = (GetSupportedLocationTypesMethodState)replacement;
                            }
                        }
                    }

                    instance = GetSupportedLocationTypes;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.GetUnits:
                {
                    if (createOrReplace)
                    {
                        if (GetUnits == null)
                        {
                            if (replacement == null)
                            {
                                GetUnits = new MethodState(this);
                            }
                            else
                            {
                                GetUnits = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GetUnits;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.LengthUnit:
                {
                    if (createOrReplace)
                    {
                        if (LengthUnit == null)
                        {
                            if (replacement == null)
                            {
                                LengthUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                LengthUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = LengthUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.RotationalUnit:
                {
                    if (createOrReplace)
                    {
                        if (RotationalUnit == null)
                        {
                            if (replacement == null)
                            {
                                RotationalUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                RotationalUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = RotationalUnit;
                    break;
                }

                case Opc.Ua.AutoID.BrowseNames.SpeedUnit:
                {
                    if (createOrReplace)
                    {
                        if (SpeedUnit == null)
                        {
                            if (replacement == null)
                            {
                                SpeedUnit = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                SpeedUnit = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = SpeedUnit;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<EUInformation> m_geographicalUnit;
        private GetLocationMethodState m_getLocationMethod;
        private GetSupportedLocationTypesMethodState m_getSupportedLocationTypesMethod;
        private MethodState m_getUnitsMethod;
        private PropertyState<EUInformation> m_lengthUnit;
        private PropertyState<EUInformation> m_rotationalUnit;
        private PropertyState<EUInformation> m_speedUnit;
        #endregion
    }
    #endif
    #endregion

    #region GetDeviceLocationMethodState Class
    #if (!OPCUA_EXCLUDE_GetDeviceLocationMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetDeviceLocationMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GetDeviceLocationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GetDeviceLocationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAbAAAAR2V0RGV2aWNlTG9jYXRpb25NZXRob2RU" +
           "eXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GetDeviceLocationMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            LocationTypeEnumeration locationType = (LocationTypeEnumeration)_inputArguments[0];

            Location location = (Location)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    locationType,
                    ref location);
            }

            _outputArguments[0] = location;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GetDeviceLocationMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        LocationTypeEnumeration locationType,
        ref Location location);
    #endif
    #endregion

    #region ScanMethodState Class
    #if (!OPCUA_EXCLUDE_ScanMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScanMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ScanMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ScanMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAOAAAAU2Nhbk1ldGhvZFR5cGUBAQAAAQEAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ScanMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanSettings settings = (ScanSettings)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);

            ScanResult[] results = (ScanResult[])_outputArguments[0];
            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    settings,
                    ref results,
                    ref status);
            }

            _outputArguments[0] = results;
            _outputArguments[1] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ScanMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanSettings settings,
        ref ScanResult[] results,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region ScanStartMethodState Class
    #if (!OPCUA_EXCLUDE_ScanStartMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScanStartMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ScanStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ScanStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQATAAAAU2NhblN0YXJ0TWV0aG9kVHlwZQEBAAAB" +
           "AQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ScanStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanSettings settings = (ScanSettings)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    settings,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ScanStartMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanSettings settings,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region CloseMethodState Class
    #if (!OPCUA_EXCLUDE_CloseMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CloseMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public CloseMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new CloseMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAPAAAAQ2xvc2VNZXRob2RUeXBlAQEAAAEBAAAB" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public CloseMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint fileHandle = (uint)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    fileHandle);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult CloseMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint fileHandle);
    #endif
    #endregion

    #region GetPositionMethodState Class
    #if (!OPCUA_EXCLUDE_GetPositionMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetPositionMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GetPositionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GetPositionMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAVAAAAR2V0UG9zaXRpb25NZXRob2RUeXBlAQEA" +
           "AAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GetPositionMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint fileHandle = (uint)_inputArguments[0];

            ulong position = (ulong)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    fileHandle,
                    ref position);
            }

            _outputArguments[0] = position;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GetPositionMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint fileHandle,
        ref ulong position);
    #endif
    #endregion

    #region OpenMethodState Class
    #if (!OPCUA_EXCLUDE_OpenMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpenMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public OpenMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new OpenMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAOAAAAT3Blbk1ldGhvZFR5cGUBAQAAAQEAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public OpenMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            byte mode = (byte)_inputArguments[0];

            uint fileHandle = (uint)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    mode,
                    ref fileHandle);
            }

            _outputArguments[0] = fileHandle;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult OpenMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte mode,
        ref uint fileHandle);
    #endif
    #endregion

    #region ReadMethodState Class
    #if (!OPCUA_EXCLUDE_ReadMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReadMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ReadMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ReadMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAOAAAAUmVhZE1ldGhvZFR5cGUBAQAAAQEAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ReadMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint fileHandle = (uint)_inputArguments[0];
            int length = (int)_inputArguments[1];

            byte[] data = (byte[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    fileHandle,
                    length,
                    ref data);
            }

            _outputArguments[0] = data;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ReadMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint fileHandle,
        int length,
        ref byte[] data);
    #endif
    #endregion

    #region SetPositionMethodState Class
    #if (!OPCUA_EXCLUDE_SetPositionMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetPositionMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetPositionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetPositionMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAVAAAAU2V0UG9zaXRpb25NZXRob2RUeXBlAQEA" +
           "AAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetPositionMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint fileHandle = (uint)_inputArguments[0];
            ulong position = (ulong)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    fileHandle,
                    position);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetPositionMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint fileHandle,
        ulong position);
    #endif
    #endregion

    #region WriteMethodState Class
    #if (!OPCUA_EXCLUDE_WriteMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WriteMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public WriteMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new WriteMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAPAAAAV3JpdGVNZXRob2RUeXBlAQEAAAEBAAAB" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public WriteMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint fileHandle = (uint)_inputArguments[0];
            byte[] data = (byte[])_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    fileHandle,
                    data);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult WriteMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint fileHandle,
        byte[] data);
    #endif
    #endregion

    #region KillTagMethodState Class
    #if (!OPCUA_EXCLUDE_KillTagMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class KillTagMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public KillTagMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new KillTagMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQARAAAAS2lsbFRhZ01ldGhvZFR5cGUBAQAAAQEA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public KillTagMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            byte[] killPassword = (byte[])_inputArguments[2];

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    killPassword,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult KillTagMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        byte[] killPassword,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region LockTagMethodState Class
    #if (!OPCUA_EXCLUDE_LockTagMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LockTagMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public LockTagMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new LockTagMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQARAAAATG9ja1RhZ01ldGhvZFR5cGUBAQAAAQEA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public LockTagMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            byte[] password = (byte[])_inputArguments[2];
            RfidLockRegionEnumeration region = (RfidLockRegionEnumeration)_inputArguments[3];
            RfidLockOperationEnumeration _lock = (RfidLockOperationEnumeration)_inputArguments[4];
            uint offset = (uint)_inputArguments[5];
            uint length = (uint)_inputArguments[6];

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    password,
                    region,
                    _lock,
                    offset,
                    length,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult LockTagMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        byte[] password,
        RfidLockRegionEnumeration region,
        RfidLockOperationEnumeration _lock,
        uint offset,
        uint length,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region ReadTagMethodState Class
    #if (!OPCUA_EXCLUDE_ReadTagMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReadTagMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ReadTagMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ReadTagMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQARAAAAUmVhZFRhZ01ldGhvZFR5cGUBAQAAAQEA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ReadTagMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            ushort region = (ushort)_inputArguments[2];
            uint offset = (uint)_inputArguments[3];
            uint length = (uint)_inputArguments[4];
            byte[] password = (byte[])_inputArguments[5];

            byte[] resultData = (byte[])_outputArguments[0];
            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    region,
                    offset,
                    length,
                    password,
                    ref resultData,
                    ref status);
            }

            _outputArguments[0] = resultData;
            _outputArguments[1] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ReadTagMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        ushort region,
        uint offset,
        uint length,
        byte[] password,
        ref byte[] resultData,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region SetTagPasswordMethodState Class
    #if (!OPCUA_EXCLUDE_SetTagPasswordMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetTagPasswordMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetTagPasswordMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetTagPasswordMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAYAAAAU2V0VGFnUGFzc3dvcmRNZXRob2RUeXBl" +
           "AQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetTagPasswordMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            RfidPasswordTypeEnumeration passwordType = (RfidPasswordTypeEnumeration)_inputArguments[2];
            byte[] accessPassword = (byte[])_inputArguments[3];
            byte[] newPassword = (byte[])_inputArguments[4];

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    passwordType,
                    accessPassword,
                    newPassword,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetTagPasswordMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        RfidPasswordTypeEnumeration passwordType,
        byte[] accessPassword,
        byte[] newPassword,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region WriteTagMethodState Class
    #if (!OPCUA_EXCLUDE_WriteTagMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WriteTagMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public WriteTagMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new WriteTagMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQASAAAAV3JpdGVUYWdNZXRob2RUeXBlAQEAAAEB" +
           "AAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public WriteTagMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            ushort region = (ushort)_inputArguments[2];
            uint offset = (uint)_inputArguments[3];
            byte[] data = (byte[])_inputArguments[4];
            byte[] password = (byte[])_inputArguments[5];

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    region,
                    offset,
                    data,
                    password,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult WriteTagMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        ushort region,
        uint offset,
        byte[] data,
        byte[] password,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region WriteTagIDMethodState Class
    #if (!OPCUA_EXCLUDE_WriteTagIDMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WriteTagIDMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public WriteTagIDMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new WriteTagIDMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAUAAAAV3JpdGVUYWdJRE1ldGhvZFR5cGUBAQAA" +
           "AQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public WriteTagIDMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            string codeType = (string)_inputArguments[1];
            byte[] newUId = (byte[])_inputArguments[2];
            byte aFI = (byte)_inputArguments[3];
            bool toggle = (bool)_inputArguments[4];
            byte[] password = (byte[])_inputArguments[5];

            AutoIdOperationStatusEnumeration status = (AutoIdOperationStatusEnumeration)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    codeType,
                    newUId,
                    aFI,
                    toggle,
                    password,
                    ref status);
            }

            _outputArguments[0] = status;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult WriteTagIDMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        string codeType,
        byte[] newUId,
        byte aFI,
        bool toggle,
        byte[] password,
        ref AutoIdOperationStatusEnumeration status);
    #endif
    #endregion

    #region GetLocationMethodState Class
    #if (!OPCUA_EXCLUDE_GetLocationMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetLocationMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GetLocationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GetLocationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAVAAAAR2V0TG9jYXRpb25NZXRob2RUeXBlAQEA" +
           "AAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GetLocationMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            ScanData identifier = (ScanData)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[0]);
            LocationTypeEnumeration locationType = (LocationTypeEnumeration)_inputArguments[1];
            string codeType = (string)_inputArguments[2];

            RtlsLocationResult result = (RtlsLocationResult)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    identifier,
                    locationType,
                    codeType,
                    ref result);
            }

            _outputArguments[0] = result;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GetLocationMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ScanData identifier,
        LocationTypeEnumeration locationType,
        string codeType,
        ref RtlsLocationResult result);
    #endif
    #endregion

    #region GetSupportedLocationTypesMethodState Class
    #if (!OPCUA_EXCLUDE_GetSupportedLocationTypesMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetSupportedLocationTypesMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GetSupportedLocationTypesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GetSupportedLocationTypesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQXV0b0lELx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAjAAAAR2V0U3VwcG9ydGVkTG9jYXRpb25UeXBl" +
           "c01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GetSupportedLocationTypesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            LocationTypeEnumeration[] supportedLocationTypes = (LocationTypeEnumeration[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref supportedLocationTypes);
            }

            _outputArguments[0] = supportedLocationTypes;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GetSupportedLocationTypesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref LocationTypeEnumeration[] supportedLocationTypes);
    #endif
    #endregion
}
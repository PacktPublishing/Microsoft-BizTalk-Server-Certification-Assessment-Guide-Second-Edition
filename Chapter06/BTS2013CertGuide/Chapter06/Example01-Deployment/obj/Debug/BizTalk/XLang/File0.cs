
#pragma warning disable 162

namespace Example01_Deployment
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "MBWRecall",
        new System.Type[]{
            typeof(Example01_Deployment.__messagetype_Example01_Deployment_MBWRecall)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MBWRecallPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MBWRecallPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MBWRecallPortType(MBWRecallPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MBWRecallPortType p = new MBWRecallPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo MBWRecall = new Microsoft.XLANGs.Core.OperationInfo
        (
            "MBWRecall",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(MBWRecallPortType),
            typeof(__messagetype_Example01_Deployment_MBWRecall),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "MBWRecall" ] = MBWRecall;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "HWLCRecall",
        new System.Type[]{
            typeof(Example01_Deployment.__messagetype_Example01_Deployment_HWLCRecall)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class HWLCPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public HWLCPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public HWLCPortType(HWLCPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            HWLCPortType p = new HWLCPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo HWLCRecall = new Microsoft.XLANGs.Core.OperationInfo
        (
            "HWLCRecall",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(HWLCPortType),
            typeof(__messagetype_Example01_Deployment_HWLCRecall),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "HWLCRecall" ] = HWLCRecall;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 172 "C:\BTS2013CertGuide\Chapter06\Example01-Deployment\ProcessPartRecall.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "MBWRecallIN", "MBWRecall", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Example01_Deployment.MBWRecallPortType),
            typeof(Example01_Deployment.HWLCPortType)
        },
        new System.String[] {
            "MBWRecallIN",
            "HWLCRecallOUT"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcessPartRecall : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessPartRecall));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ProcessPartRecall()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __ProcessPartRecall_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessPartRecall(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessPartRecall", tracker)
        {
            ConstructorHelper();
        }

        public ProcessPartRecall(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessPartRecall")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>c966d8ac-654b-4422-aa70-b43afb6ea0b6</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2d21bf66-233e-47d2-b92a-5a137aca6983</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>RcvMBWRecall</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>0d10510e-fc74-4b59-82c7-592c6ccf1254</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructHWLCRecall</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a88085a0-af6e-4b09-9abd-ce27084d8891</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>TxMBWRecall</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c6ac7dac-052d-4cb3-b52e-1cb4f63c7626</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f71a3295-b8f8-4ce3-adbd-0e6846beb29a</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6f4c8bc5-f4dc-4f20-bdbe-e3e3ba968fe3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f54284a2-300d-4d2c-9f57-3d6fc91d38be</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SndHWLCRecall</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessPartRecall'</ActionName><IsAtomic>0</IsAtomic><Line>172</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'2d21bf66-233e-47d2-b92a-5a137aca6983'</ShapeID>
<Messages>
	<MsgInfo><name>msgMBWRecall</name><part>part</part><schema>Example01_Deployment.MBWRecall</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>185</Line><Position>13</Position><ShapeID>'0d10510e-fc74-4b59-82c7-592c6ccf1254'</ShapeID>
<Messages>
	<MsgInfo><name>msgHWLCRecall</name><part>part</part><schema>Example01_Deployment.HWLCRecall</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgMBWRecall</name><part>part</part><schema>Example01_Deployment.MBWRecall</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>191</Line><Position>13</Position><ShapeID>'f54284a2-300d-4d2c-9f57-3d6fc91d38be'</ShapeID>
<Messages>
	<MsgInfo><name>msgHWLCRecall</name><part>part</part><schema>Example01_Deployment.HWLCRecall</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='682c350b-4070-47bf-8072-aa85053b778f' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Example01_Deployment' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='d83f4093-0708-4f95-8ad4-38414714a7c6' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MBWRecallPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='461e9a61-622d-4821-800a-ccc95e9c866d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MBWRecall' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='6bef5bd0-f296-4df4-934b-186e5b4b692f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='Example01_Deployment.MBWRecall' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='9219329e-6851-45fd-8dc3-9a65cc14c421' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='HWLCPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='1d7e37ae-762c-48c9-9ee6-4cd7a60c1ab5' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='HWLCRecall' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a24787de-5ba6-4eaa-9d5e-f3f9c3d60d1f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.23'>
                    <om:Property Name='Ref' Value='Example01_Deployment.HWLCRecall' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='763e544b-4817-4a5a-8c73-1add9c609e96' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessPartRecall' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='c966d8ac-654b-4422-aa70-b43afb6ea0b6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='2d21bf66-233e-47d2-b92a-5a137aca6983' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='MBWRecallIN' />
                    <om:Property Name='MessageName' Value='msgMBWRecall' />
                    <om:Property Name='OperationName' Value='MBWRecall' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='RcvMBWRecall' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='0d10510e-fc74-4b59-82c7-592c6ccf1254' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='37.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructHWLCRecall' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='a88085a0-af6e-4b09-9abd-ce27084d8891' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                        <om:Property Name='ClassName' Value='Example01_Deployment.MBWRecall_to_HWLCRecall' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='TxMBWRecall' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='c6ac7dac-052d-4cb3-b52e-1cb4f63c7626' ParentLink='Transform_InputMessagePartRef' LowerBound='35.91' HigherBound='35.103'>
                            <om:Property Name='MessageRef' Value='msgMBWRecall' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='f71a3295-b8f8-4ce3-adbd-0e6846beb29a' ParentLink='Transform_OutputMessagePartRef' LowerBound='35.28' HigherBound='35.41'>
                            <om:Property Name='MessageRef' Value='msgHWLCRecall' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='6f4c8bc5-f4dc-4f20-bdbe-e3e3ba968fe3' ParentLink='Construct_MessageRef' LowerBound='32.23' HigherBound='32.36'>
                        <om:Property Name='Ref' Value='msgHWLCRecall' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f54284a2-300d-4d2c-9f57-3d6fc91d38be' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='HWLCRecallOUT' />
                    <om:Property Name='MessageName' Value='msgHWLCRecall' />
                    <om:Property Name='OperationName' Value='HWLCRecall' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SndHWLCRecall' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d279b238-0660-437b-8f7d-64104412f46e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='5' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Example01_Deployment.MBWRecallPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MBWRecallIN' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='db8ff4de-088e-4ef7-8741-6e054605fe66' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f616aa27-082b-45a4-a300-1f44c8884db8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Example01_Deployment.HWLCPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='HWLCRecallOUT' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9e60d74d-a228-475b-beeb-cf93b8ce2b2d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8277dbbd-a533-43e9-a205-d77f2d12e839' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Example01_Deployment.MBWRecall' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgMBWRecall' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cea4d6b5-1cd0-4e09-857e-a0e41aadcd07' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Example01_Deployment.HWLCRecall' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgHWLCRecall' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessPartRecall_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessPartRecall_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessPartRecall")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessPartRecall __svc__ = (ProcessPartRecall)_service;
                __ProcessPartRecall_root_0 __ctx0__ = (__ProcessPartRecall_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.MBWRecallIN != null)
                {
                    __svc__.MBWRecallIN.Close(this, null);
                    __svc__.MBWRecallIN = null;
                }
                if (__svc__.HWLCRecallOUT != null)
                {
                    __svc__.HWLCRecallOUT.Close(this, null);
                    __svc__.HWLCRecallOUT = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcessPartRecall_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ProcessPartRecall_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessPartRecall")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessPartRecall __svc__ = (ProcessPartRecall)_service;
                __ProcessPartRecall_1 __ctx1__ = (__ProcessPartRecall_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgMBWRecall != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgMBWRecall);
                    __ctx1__.__msgMBWRecall = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgHWLCRecall != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgHWLCRecall);
                    __ctx1__.__msgHWLCRecall = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgMBWRecall")]
            public __messagetype_Example01_Deployment_MBWRecall __msgMBWRecall;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgHWLCRecall")]
            public __messagetype_Example01_Deployment_HWLCRecall __msgHWLCRecall;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MBWRecallIN")]
        internal MBWRecallPortType MBWRecallIN;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("HWLCRecallOUT")]
        internal HWLCPortType HWLCRecallOUT;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MBWRecallPortType.MBWRecall},
                                               typeof(ProcessPartRecall).GetField("MBWRecallIN", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessPartRecall), "MBWRecallIN"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {HWLCPortType.HWLCRecall},
                                               typeof(ProcessPartRecall).GetField("HWLCRecallOUT", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessPartRecall), "HWLCRecallOUT"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "2d21bf66-233e-47d2-b92a-5a137aca6983", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "2d21bf66-233e-47d2-b92a-5a137aca6983", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "0d10510e-fc74-4b59-82c7-592c6ccf1254", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "0d10510e-fc74-4b59-82c7-592c6ccf1254", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f54284a2-300d-4d2c-9f57-3d6fc91d38be", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f54284a2-300d-4d2c-9f57-3d6fc91d38be", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessPartRecall_1 __ctx1__ = (__ProcessPartRecall_1)_stateMgrs[1];
            __ProcessPartRecall_root_0 __ctx0__ = (__ProcessPartRecall_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                MBWRecallIN = new MBWRecallPortType(0, this);
                HWLCRecallOUT = new HWLCPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], MBWRecallIN, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessPartRecall_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ProcessPartRecall_1 __ctx1__ = (__ProcessPartRecall_1)_stateMgrs[1];
            __ProcessPartRecall_root_0 __ctx0__ = (__ProcessPartRecall_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!MBWRecallIN.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgMBWRecall != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgMBWRecall);
                __ctx1__.__msgMBWRecall = new __messagetype_Example01_Deployment_MBWRecall("msgMBWRecall", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgMBWRecall);
                MBWRecallIN.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgMBWRecall, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (MBWRecallIN != null)
                {
                    MBWRecallIN.Close(__ctx1__, __seg__);
                    MBWRecallIN = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgMBWRecall);
                    __edata.PortName = @"MBWRecallIN";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Example01_Deployment_HWLCRecall __msgHWLCRecall = new __messagetype_Example01_Deployment_HWLCRecall("msgHWLCRecall", __ctx1__);

                    ApplyTransform(typeof(Example01_Deployment.MBWRecall_to_HWLCRecall), new object[] {__msgHWLCRecall.part}, new object[] {__ctx1__.__msgMBWRecall.part});

                    if (__ctx1__.__msgHWLCRecall != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgHWLCRecall);
                    __ctx1__.__msgHWLCRecall = __msgHWLCRecall;
                    __ctx1__.RefMessage(__ctx1__.__msgHWLCRecall);
                }
                __ctx1__.__msgHWLCRecall.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgHWLCRecall);
                    __edata.Messages.Add(__ctx1__.__msgMBWRecall);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgMBWRecall != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgMBWRecall);
                    __ctx1__.__msgMBWRecall = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                HWLCRecallOUT.SendMessage(0, __ctx1__.__msgHWLCRecall, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (HWLCRecallOUT != null)
                {
                    HWLCRecallOUT.Close(__ctx1__, __seg__);
                    HWLCRecallOUT = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgHWLCRecall);
                    __edata.PortName = @"HWLCRecallOUT";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgHWLCRecall != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgHWLCRecall);
                    __ctx1__.__msgHWLCRecall = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Example01_Deployment_MBWRecall__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Example01_Deployment.MBWRecall _schema = new Example01_Deployment.MBWRecall();

        public __Example01_Deployment_MBWRecall__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Example01_Deployment.MBWRecall",
        new System.Type[]{
            typeof(Example01_Deployment.MBWRecall)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Example01_Deployment_MBWRecall__)
        },
        0,
        @"http://Example01_Deployment.MBWRecall#MBWRecall"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Example01_Deployment_MBWRecall : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Example01_Deployment_MBWRecall__ part;

        private void __CreatePartWrappers()
        {
            part = new __Example01_Deployment_MBWRecall__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Example01_Deployment_MBWRecall(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Example01_Deployment_HWLCRecall__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Example01_Deployment.HWLCRecall _schema = new Example01_Deployment.HWLCRecall();

        public __Example01_Deployment_HWLCRecall__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Example01_Deployment.HWLCRecall",
        new System.Type[]{
            typeof(Example01_Deployment.HWLCRecall)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Example01_Deployment_HWLCRecall__)
        },
        0,
        @"http://Example01_Deployment.HWLCRecall#HWLCRecall"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Example01_Deployment_HWLCRecall : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Example01_Deployment_HWLCRecall__ part;

        private void __CreatePartWrappers()
        {
            part = new __Example01_Deployment_HWLCRecall__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Example01_Deployment_HWLCRecall(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}

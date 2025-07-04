using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Managed.Win32.Msxml.Methods;

namespace Managed.Win32.Msxml
{
    public unsafe partial struct _xml_error
    {
        [NativeTypeName("unsigned int")]
        public uint _nLine;

        [NativeTypeName("BSTR")]
        public char* _pchBuf;

        [NativeTypeName("unsigned int")]
        public uint _cchBuf;

        [NativeTypeName("unsigned int")]
        public uint _ich;

        [NativeTypeName("BSTR")]
        public char* _pszFound;

        [NativeTypeName("BSTR")]
        public char* _pszExpected;

        [NativeTypeName("DWORD")]
        public uint _reserved1;

        [NativeTypeName("DWORD")]
        public uint _reserved2;
    }

    public enum tagDOMNodeType
    {
        NODE_INVALID = 0,
        NODE_ELEMENT = (NODE_INVALID + 1),
        NODE_ATTRIBUTE = (NODE_ELEMENT + 1),
        NODE_TEXT = (NODE_ATTRIBUTE + 1),
        NODE_CDATA_SECTION = (NODE_TEXT + 1),
        NODE_ENTITY_REFERENCE = (NODE_CDATA_SECTION + 1),
        NODE_ENTITY = (NODE_ENTITY_REFERENCE + 1),
        NODE_PROCESSING_INSTRUCTION = (NODE_ENTITY + 1),
        NODE_COMMENT = (NODE_PROCESSING_INSTRUCTION + 1),
        NODE_DOCUMENT = (NODE_COMMENT + 1),
        NODE_DOCUMENT_TYPE = (NODE_DOCUMENT + 1),
        NODE_DOCUMENT_FRAGMENT = (NODE_DOCUMENT_TYPE + 1),
        NODE_NOTATION = (NODE_DOCUMENT_FRAGMENT + 1),
    }

    public enum tagXMLEMEM_TYPE
    {
        XMLELEMTYPE_ELEMENT = 0,
        XMLELEMTYPE_TEXT = (XMLELEMTYPE_ELEMENT + 1),
        XMLELEMTYPE_COMMENT = (XMLELEMTYPE_TEXT + 1),
        XMLELEMTYPE_DOCUMENT = (XMLELEMTYPE_COMMENT + 1),
        XMLELEMTYPE_DTD = (XMLELEMTYPE_DOCUMENT + 1),
        XMLELEMTYPE_PI = (XMLELEMTYPE_DTD + 1),
        XMLELEMTYPE_OTHER = (XMLELEMTYPE_PI + 1),
    }

    [Guid("2933BF8F-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMImplementation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMImplementation : IXMLDOMImplementation.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMImplementation));

        public Vtbl<IXMLDOMImplementation>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMImplementation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMImplementation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasFeature([NativeTypeName("BSTR")] char* feature, [NativeTypeName("BSTR")] char* version, [NativeTypeName("VARIANT_BOOL *")] short* hasFeature)
        {
            return lpVtbl->hasFeature((IXMLDOMImplementation*)Unsafe.AsPointer(ref this), feature, version, hasFeature);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int hasFeature([NativeTypeName("BSTR")] char* feature, [NativeTypeName("BSTR")] char* version, [NativeTypeName("VARIANT_BOOL *")] short* hasFeature);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, short*, int> hasFeature;
        }
    }

    [Guid("2933BF80-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNode : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMNode : IXMLDOMNode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNode));

        public Vtbl<IXMLDOMNode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMNode*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMNode*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMNode*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMNode*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMNode*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMNode*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMNode*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMNode*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMNode*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMNode*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMNode*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMNode*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMNode*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMNode*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMNode*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMNode*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMNode*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_nodeName([NativeTypeName("BSTR *")] char** name);

            [return: NativeTypeName("HRESULT")]
            int get_nodeValue(VARIANT* value);

            [return: NativeTypeName("HRESULT")]
            int put_nodeValue(VARIANT value);

            [return: NativeTypeName("HRESULT")]
            int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type);

            [return: NativeTypeName("HRESULT")]
            int get_parentNode(IXMLDOMNode** parent);

            [return: NativeTypeName("HRESULT")]
            int get_childNodes(IXMLDOMNodeList** childList);

            [return: NativeTypeName("HRESULT")]
            int get_firstChild(IXMLDOMNode** firstChild);

            [return: NativeTypeName("HRESULT")]
            int get_lastChild(IXMLDOMNode** lastChild);

            [return: NativeTypeName("HRESULT")]
            int get_previousSibling(IXMLDOMNode** previousSibling);

            [return: NativeTypeName("HRESULT")]
            int get_nextSibling(IXMLDOMNode** nextSibling);

            [return: NativeTypeName("HRESULT")]
            int get_attributes(IXMLDOMNamedNodeMap** attributeMap);

            [return: NativeTypeName("HRESULT")]
            int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild);

            [return: NativeTypeName("HRESULT")]
            int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild);

            [return: NativeTypeName("HRESULT")]
            int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild);

            [return: NativeTypeName("HRESULT")]
            int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild);

            [return: NativeTypeName("HRESULT")]
            int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild);

            [return: NativeTypeName("HRESULT")]
            int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument);

            [return: NativeTypeName("HRESULT")]
            int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot);

            [return: NativeTypeName("HRESULT")]
            int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType);

            [return: NativeTypeName("HRESULT")]
            int get_text([NativeTypeName("BSTR *")] char** text);

            [return: NativeTypeName("HRESULT")]
            int put_text([NativeTypeName("BSTR")] char* text);

            [return: NativeTypeName("HRESULT")]
            int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified);

            [return: NativeTypeName("HRESULT")]
            int get_definition(IXMLDOMNode** definitionNode);

            [return: NativeTypeName("HRESULT")]
            int get_nodeTypedValue(VARIANT* typedValue);

            [return: NativeTypeName("HRESULT")]
            int put_nodeTypedValue(VARIANT typedValue);

            [return: NativeTypeName("HRESULT")]
            int get_dataType(VARIANT* dataTypeName);

            [return: NativeTypeName("HRESULT")]
            int put_dataType([NativeTypeName("BSTR")] char* dataTypeName);

            [return: NativeTypeName("HRESULT")]
            int get_xml([NativeTypeName("BSTR *")] char** xmlString);

            [return: NativeTypeName("HRESULT")]
            int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString);

            [return: NativeTypeName("HRESULT")]
            int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList);

            [return: NativeTypeName("HRESULT")]
            int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode);

            [return: NativeTypeName("HRESULT")]
            int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed);

            [return: NativeTypeName("HRESULT")]
            int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI);

            [return: NativeTypeName("HRESULT")]
            int get_prefix([NativeTypeName("BSTR *")] char** prefixString);

            [return: NativeTypeName("HRESULT")]
            int get_baseName([NativeTypeName("BSTR *")] char** nameString);

            [return: NativeTypeName("HRESULT")]
            int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
        }
    }

    [Guid("3EFAA413-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct IXMLDOMDocumentFragment : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMDocumentFragment : IXMLDOMDocumentFragment.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMDocumentFragment));

        public Vtbl<IXMLDOMDocumentFragment>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
        }
    }

    [Guid("2933BF81-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMDocument : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMDocument : IXMLDOMDocument.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMDocument));

        public Vtbl<IXMLDOMDocument>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_doctype(IXMLDOMDocumentType** documentType)
        {
            return lpVtbl->get_doctype((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_implementation(IXMLDOMImplementation** impl)
        {
            return lpVtbl->get_implementation((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_documentElement(IXMLDOMElement** DOMElement)
        {
            return lpVtbl->get_documentElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_documentElement(IXMLDOMElement* DOMElement)
        {
            return lpVtbl->putref_documentElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] char* tagName, IXMLDOMElement** element)
        {
            return lpVtbl->createElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createDocumentFragment(IXMLDOMDocumentFragment** docFrag)
        {
            return lpVtbl->createDocumentFragment((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createTextNode([NativeTypeName("BSTR")] char* data, IXMLDOMText** text)
        {
            return lpVtbl->createTextNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createComment([NativeTypeName("BSTR")] char* data, IXMLDOMComment** comment)
        {
            return lpVtbl->createComment((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createCDATASection([NativeTypeName("BSTR")] char* data, IXMLDOMCDATASection** cdata)
        {
            return lpVtbl->createCDATASection((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createProcessingInstruction([NativeTypeName("BSTR")] char* target, [NativeTypeName("BSTR")] char* data, IXMLDOMProcessingInstruction** pi)
        {
            return lpVtbl->createProcessingInstruction((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createAttribute([NativeTypeName("BSTR")] char* name, IXMLDOMAttribute** attribute)
        {
            return lpVtbl->createAttribute((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createEntityReference([NativeTypeName("BSTR")] char* name, IXMLDOMEntityReference** entityRef)
        {
            return lpVtbl->createEntityReference((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] char* tagName, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->getElementsByTagName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createNode(VARIANT Type, [NativeTypeName("BSTR")] char* name, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** node)
        {
            return lpVtbl->createNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int nodeFromID([NativeTypeName("BSTR")] char* idString, IXMLDOMNode** node)
        {
            return lpVtbl->nodeFromID((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return lpVtbl->load((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* value)
        {
            return lpVtbl->get_readyState((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parseError(IXMLDOMParseError** errorObj)
        {
            return lpVtbl->get_parseError((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] char** urlString)
        {
            return lpVtbl->get_url((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
        {
            return lpVtbl->get_async((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
        {
            return lpVtbl->put_async((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return lpVtbl->abort((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int loadXML([NativeTypeName("BSTR")] char* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return lpVtbl->loadXML((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int save(VARIANT destination)
        {
            return lpVtbl->save((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
        {
            return lpVtbl->get_validateOnParse((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
        {
            return lpVtbl->put_validateOnParse((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
        {
            return lpVtbl->get_resolveExternals((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
        {
            return lpVtbl->put_resolveExternals((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
        {
            return lpVtbl->get_preserveWhiteSpace((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
        {
            return lpVtbl->put_preserveWhiteSpace((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT readystatechangeSink)
        {
            return lpVtbl->put_onreadystatechange((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT ondataavailableSink)
        {
            return lpVtbl->put_ondataavailable((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ontransformnode(VARIANT ontransformnodeSink)
        {
            return lpVtbl->put_ontransformnode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_doctype(IXMLDOMDocumentType** documentType);

            [return: NativeTypeName("HRESULT")]
            int get_implementation(IXMLDOMImplementation** impl);

            [return: NativeTypeName("HRESULT")]
            int get_documentElement(IXMLDOMElement** DOMElement);

            [return: NativeTypeName("HRESULT")]
            int putref_documentElement(IXMLDOMElement* DOMElement);

            [return: NativeTypeName("HRESULT")]
            int createElement([NativeTypeName("BSTR")] char* tagName, IXMLDOMElement** element);

            [return: NativeTypeName("HRESULT")]
            int createDocumentFragment(IXMLDOMDocumentFragment** docFrag);

            [return: NativeTypeName("HRESULT")]
            int createTextNode([NativeTypeName("BSTR")] char* data, IXMLDOMText** text);

            [return: NativeTypeName("HRESULT")]
            int createComment([NativeTypeName("BSTR")] char* data, IXMLDOMComment** comment);

            [return: NativeTypeName("HRESULT")]
            int createCDATASection([NativeTypeName("BSTR")] char* data, IXMLDOMCDATASection** cdata);

            [return: NativeTypeName("HRESULT")]
            int createProcessingInstruction([NativeTypeName("BSTR")] char* target, [NativeTypeName("BSTR")] char* data, IXMLDOMProcessingInstruction** pi);

            [return: NativeTypeName("HRESULT")]
            int createAttribute([NativeTypeName("BSTR")] char* name, IXMLDOMAttribute** attribute);

            [return: NativeTypeName("HRESULT")]
            int createEntityReference([NativeTypeName("BSTR")] char* name, IXMLDOMEntityReference** entityRef);

            [return: NativeTypeName("HRESULT")]
            int getElementsByTagName([NativeTypeName("BSTR")] char* tagName, IXMLDOMNodeList** resultList);

            [return: NativeTypeName("HRESULT")]
            int createNode(VARIANT Type, [NativeTypeName("BSTR")] char* name, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** node);

            [return: NativeTypeName("HRESULT")]
            int nodeFromID([NativeTypeName("BSTR")] char* idString, IXMLDOMNode** node);

            [return: NativeTypeName("HRESULT")]
            int load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

            [return: NativeTypeName("HRESULT")]
            int get_readyState([NativeTypeName("long *")] int* value);

            [return: NativeTypeName("HRESULT")]
            int get_parseError(IXMLDOMParseError** errorObj);

            [return: NativeTypeName("HRESULT")]
            int get_url([NativeTypeName("BSTR *")] char** urlString);

            [return: NativeTypeName("HRESULT")]
            int get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync);

            [return: NativeTypeName("HRESULT")]
            int put_async([NativeTypeName("VARIANT_BOOL")] short isAsync);

            [return: NativeTypeName("HRESULT")]
            int abort();

            [return: NativeTypeName("HRESULT")]
            int loadXML([NativeTypeName("BSTR")] char* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

            [return: NativeTypeName("HRESULT")]
            int save(VARIANT destination);

            [return: NativeTypeName("HRESULT")]
            int get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating);

            [return: NativeTypeName("HRESULT")]
            int put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating);

            [return: NativeTypeName("HRESULT")]
            int get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving);

            [return: NativeTypeName("HRESULT")]
            int put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving);

            [return: NativeTypeName("HRESULT")]
            int get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving);

            [return: NativeTypeName("HRESULT")]
            int put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving);

            [return: NativeTypeName("HRESULT")]
            int put_onreadystatechange(VARIANT readystatechangeSink);

            [return: NativeTypeName("HRESULT")]
            int put_ondataavailable(VARIANT ondataavailableSink);

            [return: NativeTypeName("HRESULT")]
            int put_ontransformnode(VARIANT ontransformnodeSink);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (IXMLDOMDocumentType **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocumentType**, int> get_doctype;

            [NativeTypeName("HRESULT (IXMLDOMImplementation **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMImplementation**, int> get_implementation;

            [NativeTypeName("HRESULT (IXMLDOMElement **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMElement**, int> get_documentElement;

            [NativeTypeName("HRESULT (IXMLDOMElement *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMElement*, int> putref_documentElement;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMElement **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMElement**, int> createElement;

            [NativeTypeName("HRESULT (IXMLDOMDocumentFragment **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocumentFragment**, int> createDocumentFragment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMText **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMText**, int> createTextNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMComment **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMComment**, int> createComment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMCDATASection **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMCDATASection**, int> createCDATASection;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMProcessingInstruction **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IXMLDOMProcessingInstruction**, int> createProcessingInstruction;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMAttribute**, int> createAttribute;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMEntityReference **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMEntityReference**, int> createEntityReference;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> getElementsByTagName;

            [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, char*, char*, IXMLDOMNode**, int> createNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> nodeFromID;

            [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, short*, int> load;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (IXMLDOMParseError **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMParseError**, int> get_parseError;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_url;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_async;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> abort;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> loadXML;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> save;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_onreadystatechange;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_ondataavailable;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_ontransformnode;
        }
    }

    [Guid("2933BF82-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNodeList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMNodeList : IXMLDOMNodeList.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNodeList));

        public Vtbl<IXMLDOMNodeList>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem)
        {
            return lpVtbl->get_item((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* listLength)
        {
            return lpVtbl->get_length((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), listLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int nextNode(IXMLDOMNode** nextItem)
        {
            return lpVtbl->nextNode((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), nextItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return lpVtbl->reset((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** ppUnk)
        {
            return lpVtbl->get__newEnum((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), ppUnk);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem);

            [return: NativeTypeName("HRESULT")]
            int get_length([NativeTypeName("long *")] int* listLength);

            [return: NativeTypeName("HRESULT")]
            int nextNode(IXMLDOMNode** nextItem);

            [return: NativeTypeName("HRESULT")]
            int reset();

            [return: NativeTypeName("HRESULT")]
            int get__newEnum(IUnknown** ppUnk);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, IXMLDOMNode**, int> get_item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> nextNode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> reset;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown**, int> get__newEnum;
        }
    }

    [Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNamedNodeMap : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMNamedNodeMap : IXMLDOMNamedNodeMap.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNamedNodeMap));

        public Vtbl<IXMLDOMNamedNodeMap>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getNamedItem([NativeTypeName("BSTR")] char* name, IXMLDOMNode** namedItem)
        {
            return lpVtbl->getNamedItem((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setNamedItem(IXMLDOMNode* newItem, IXMLDOMNode** nameItem)
        {
            return lpVtbl->setNamedItem((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), newItem, nameItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeNamedItem([NativeTypeName("BSTR")] char* name, IXMLDOMNode** namedItem)
        {
            return lpVtbl->removeNamedItem((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem)
        {
            return lpVtbl->get_item((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* listLength)
        {
            return lpVtbl->get_length((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), listLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getQualifiedItem([NativeTypeName("BSTR")] char* baseName, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** qualifiedItem)
        {
            return lpVtbl->getQualifiedItem((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeQualifiedItem([NativeTypeName("BSTR")] char* baseName, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** qualifiedItem)
        {
            return lpVtbl->removeQualifiedItem((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int nextNode(IXMLDOMNode** nextItem)
        {
            return lpVtbl->nextNode((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), nextItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return lpVtbl->reset((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** ppUnk)
        {
            return lpVtbl->get__newEnum((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), ppUnk);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int getNamedItem([NativeTypeName("BSTR")] char* name, IXMLDOMNode** namedItem);

            [return: NativeTypeName("HRESULT")]
            int setNamedItem(IXMLDOMNode* newItem, IXMLDOMNode** nameItem);

            [return: NativeTypeName("HRESULT")]
            int removeNamedItem([NativeTypeName("BSTR")] char* name, IXMLDOMNode** namedItem);

            [return: NativeTypeName("HRESULT")]
            int get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem);

            [return: NativeTypeName("HRESULT")]
            int get_length([NativeTypeName("long *")] int* listLength);

            [return: NativeTypeName("HRESULT")]
            int getQualifiedItem([NativeTypeName("BSTR")] char* baseName, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** qualifiedItem);

            [return: NativeTypeName("HRESULT")]
            int removeQualifiedItem([NativeTypeName("BSTR")] char* baseName, [NativeTypeName("BSTR")] char* namespaceURI, IXMLDOMNode** qualifiedItem);

            [return: NativeTypeName("HRESULT")]
            int nextNode(IXMLDOMNode** nextItem);

            [return: NativeTypeName("HRESULT")]
            int reset();

            [return: NativeTypeName("HRESULT")]
            int get__newEnum(IUnknown** ppUnk);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> getNamedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> setNamedItem;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> removeNamedItem;

            [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, IXMLDOMNode**, int> get_item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IXMLDOMNode**, int> getQualifiedItem;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IXMLDOMNode**, int> removeQualifiedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> nextNode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> reset;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown**, int> get__newEnum;
        }
    }

    [Guid("2933BF84-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMCharacterData : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMCharacterData : IXMLDOMCharacterData.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMCharacterData));

        public Vtbl<IXMLDOMCharacterData>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->get_data((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->put_data((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return lpVtbl->get_length((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->substringData((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->appendData((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->insertData((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return lpVtbl->deleteData((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->replaceData((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_data([NativeTypeName("BSTR *")] char** data);

            [return: NativeTypeName("HRESULT")]
            int put_data([NativeTypeName("BSTR")] char* data);

            [return: NativeTypeName("HRESULT")]
            int get_length([NativeTypeName("long *")] int* dataLength);

            [return: NativeTypeName("HRESULT")]
            int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] char** data);

            [return: NativeTypeName("HRESULT")]
            int appendData([NativeTypeName("BSTR")] char* data);

            [return: NativeTypeName("HRESULT")]
            int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] char* data);

            [return: NativeTypeName("HRESULT")]
            int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count);

            [return: NativeTypeName("HRESULT")]
            int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] char* data);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char**, int> substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char*, int> replaceData;
        }
    }

    [Guid("2933BF85-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMAttribute : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMAttribute : IXMLDOMAttribute.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMAttribute));

        public Vtbl<IXMLDOMAttribute>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] char** attributeName)
        {
            return lpVtbl->get_name((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_value(VARIANT* attributeValue)
        {
            return lpVtbl->get_value((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_value(VARIANT attributeValue)
        {
            return lpVtbl->put_value((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeValue);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_name([NativeTypeName("BSTR *")] char** attributeName);

            [return: NativeTypeName("HRESULT")]
            int get_value(VARIANT* attributeValue);

            [return: NativeTypeName("HRESULT")]
            int put_value(VARIANT attributeValue);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_name;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_value;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_value;
        }
    }

    [Guid("2933BF86-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMElement : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMElement : IXMLDOMElement.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMElement));

        public Vtbl<IXMLDOMElement>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMElement*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMElement*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMElement*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMElement*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMElement*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMElement*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMElement*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMElement*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMElement*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMElement*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMElement*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMElement*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMElement*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMElement*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMElement*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMElement*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMElement*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMElement*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMElement*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMElement*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMElement*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMElement*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMElement*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMElement*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMElement*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMElement*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMElement*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMElement*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMElement*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] char** tagName)
        {
            return lpVtbl->get_tagName((IXMLDOMElement*)Unsafe.AsPointer(ref this), tagName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] char* name, VARIANT* value)
        {
            return lpVtbl->getAttribute((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] char* name, VARIANT value)
        {
            return lpVtbl->setAttribute((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] char* name)
        {
            return lpVtbl->removeAttribute((IXMLDOMElement*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNode([NativeTypeName("BSTR")] char* name, IXMLDOMAttribute** attributeNode)
        {
            return lpVtbl->getAttributeNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, attributeNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNode(IXMLDOMAttribute* DOMAttribute, IXMLDOMAttribute** attributeNode)
        {
            return lpVtbl->setAttributeNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), DOMAttribute, attributeNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNode(IXMLDOMAttribute* DOMAttribute, IXMLDOMAttribute** attributeNode)
        {
            return lpVtbl->removeAttributeNode((IXMLDOMElement*)Unsafe.AsPointer(ref this), DOMAttribute, attributeNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] char* tagName, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->getElementsByTagName((IXMLDOMElement*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return lpVtbl->normalize((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_tagName([NativeTypeName("BSTR *")] char** tagName);

            [return: NativeTypeName("HRESULT")]
            int getAttribute([NativeTypeName("BSTR")] char* name, VARIANT* value);

            [return: NativeTypeName("HRESULT")]
            int setAttribute([NativeTypeName("BSTR")] char* name, VARIANT value);

            [return: NativeTypeName("HRESULT")]
            int removeAttribute([NativeTypeName("BSTR")] char* name);

            [return: NativeTypeName("HRESULT")]
            int getAttributeNode([NativeTypeName("BSTR")] char* name, IXMLDOMAttribute** attributeNode);

            [return: NativeTypeName("HRESULT")]
            int setAttributeNode(IXMLDOMAttribute* DOMAttribute, IXMLDOMAttribute** attributeNode);

            [return: NativeTypeName("HRESULT")]
            int removeAttributeNode(IXMLDOMAttribute* DOMAttribute, IXMLDOMAttribute** attributeNode);

            [return: NativeTypeName("HRESULT")]
            int getElementsByTagName([NativeTypeName("BSTR")] char* tagName, IXMLDOMNodeList** resultList);

            [return: NativeTypeName("HRESULT")]
            int normalize();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_tagName;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> setAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> removeAttribute;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMAttribute**, int> getAttributeNode;

            [NativeTypeName("HRESULT (IXMLDOMAttribute *, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMAttribute*, IXMLDOMAttribute**, int> setAttributeNode;

            [NativeTypeName("HRESULT (IXMLDOMAttribute *, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMAttribute*, IXMLDOMAttribute**, int> removeAttributeNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> getElementsByTagName;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> normalize;
        }
    }

    [Guid("2933BF87-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMText : IXMLDOMCharacterData")]
    [NativeInheritance("IXMLDOMCharacterData")]
    public unsafe partial struct IXMLDOMText : IXMLDOMText.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMText));

        public Vtbl<IXMLDOMText>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMText*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMText*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMText*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMText*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMText*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMText*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMText*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMText*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMText*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMText*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMText*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMText*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMText*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMText*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMText*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMText*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMText*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMText*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMText*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMText*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMText*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMText*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMText*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMText*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMText*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMText*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMText*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMText*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMText*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMText*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMText*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMText*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMText*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMText*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMText*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMText*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMText*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMText*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMText*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMText*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->get_data((IXMLDOMText*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->put_data((IXMLDOMText*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return lpVtbl->get_length((IXMLDOMText*)Unsafe.AsPointer(ref this), dataLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->substringData((IXMLDOMText*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->appendData((IXMLDOMText*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->insertData((IXMLDOMText*)Unsafe.AsPointer(ref this), offset, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return lpVtbl->deleteData((IXMLDOMText*)Unsafe.AsPointer(ref this), offset, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->replaceData((IXMLDOMText*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int splitText([NativeTypeName("long")] int offset, IXMLDOMText** rightHandTextNode)
        {
            return lpVtbl->splitText((IXMLDOMText*)Unsafe.AsPointer(ref this), offset, rightHandTextNode);
        }

        public interface Interface : IXMLDOMCharacterData.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int splitText([NativeTypeName("long")] int offset, IXMLDOMText** rightHandTextNode);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char**, int> substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char*, int> replaceData;

            [NativeTypeName("HRESULT (long, IXMLDOMText **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, IXMLDOMText**, int> splitText;
        }
    }

    [Guid("2933BF88-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMComment : IXMLDOMCharacterData")]
    [NativeInheritance("IXMLDOMCharacterData")]
    public unsafe partial struct IXMLDOMComment : IXMLDOMComment.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMComment));

        public Vtbl<IXMLDOMComment>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMComment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMComment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMComment*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMComment*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMComment*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMComment*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMComment*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMComment*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMComment*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMComment*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMComment*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMComment*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMComment*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMComment*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMComment*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMComment*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMComment*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMComment*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMComment*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMComment*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMComment*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMComment*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMComment*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMComment*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMComment*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMComment*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->get_data((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->put_data((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return lpVtbl->get_length((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->substringData((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->appendData((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->insertData((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return lpVtbl->deleteData((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->replaceData((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        public interface Interface : IXMLDOMCharacterData.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char**, int> substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char*, int> replaceData;
        }
    }

    [Guid("2933BF89-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMProcessingInstruction : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMProcessingInstruction : IXMLDOMProcessingInstruction.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMProcessingInstruction));

        public Vtbl<IXMLDOMProcessingInstruction>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_target([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_target((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] char** value)
        {
            return lpVtbl->get_data((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] char* value)
        {
            return lpVtbl->put_data((IXMLDOMProcessingInstruction*)Unsafe.AsPointer(ref this), value);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_target([NativeTypeName("BSTR *")] char** name);

            [return: NativeTypeName("HRESULT")]
            int get_data([NativeTypeName("BSTR *")] char** value);

            [return: NativeTypeName("HRESULT")]
            int put_data([NativeTypeName("BSTR")] char* value);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_target;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_data;
        }
    }

    [Guid("2933BF8A-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMCDATASection : IXMLDOMText")]
    [NativeInheritance("IXMLDOMText")]
    public unsafe partial struct IXMLDOMCDATASection : IXMLDOMCDATASection.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMCDATASection));

        public Vtbl<IXMLDOMCDATASection>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->get_data((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->put_data((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return lpVtbl->get_length((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] char** data)
        {
            return lpVtbl->substringData((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->appendData((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->insertData((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return lpVtbl->deleteData((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] char* data)
        {
            return lpVtbl->replaceData((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int splitText([NativeTypeName("long")] int offset, IXMLDOMText** rightHandTextNode)
        {
            return lpVtbl->splitText((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, rightHandTextNode);
        }

        public interface Interface : IXMLDOMText.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char**, int> substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char*, int> replaceData;

            [NativeTypeName("HRESULT (long, IXMLDOMText **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, IXMLDOMText**, int> splitText;
        }
    }

    [Guid("2933BF8B-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMDocumentType : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMDocumentType : IXMLDOMDocumentType.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMDocumentType));

        public Vtbl<IXMLDOMDocumentType>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] char** rootName)
        {
            return lpVtbl->get_name((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), rootName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_entities(IXMLDOMNamedNodeMap** entityMap)
        {
            return lpVtbl->get_entities((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), entityMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_notations(IXMLDOMNamedNodeMap** notationMap)
        {
            return lpVtbl->get_notations((IXMLDOMDocumentType*)Unsafe.AsPointer(ref this), notationMap);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_name([NativeTypeName("BSTR *")] char** rootName);

            [return: NativeTypeName("HRESULT")]
            int get_entities(IXMLDOMNamedNodeMap** entityMap);

            [return: NativeTypeName("HRESULT")]
            int get_notations(IXMLDOMNamedNodeMap** notationMap);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_name;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_entities;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_notations;
        }
    }

    [Guid("2933BF8C-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNotation : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMNotation : IXMLDOMNotation.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNotation));

        public Vtbl<IXMLDOMNotation>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMNotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMNotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMNotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMNotation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMNotation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMNotation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMNotation*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMNotation*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMNotation*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMNotation*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMNotation*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMNotation*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMNotation*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMNotation*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMNotation*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMNotation*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMNotation*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMNotation*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMNotation*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMNotation*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMNotation*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMNotation*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMNotation*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMNotation*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMNotation*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMNotation*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMNotation*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMNotation*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMNotation*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMNotation*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMNotation*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMNotation*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMNotation*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMNotation*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_publicId(VARIANT* publicID)
        {
            return lpVtbl->get_publicId((IXMLDOMNotation*)Unsafe.AsPointer(ref this), publicID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemId(VARIANT* systemID)
        {
            return lpVtbl->get_systemId((IXMLDOMNotation*)Unsafe.AsPointer(ref this), systemID);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_publicId(VARIANT* publicID);

            [return: NativeTypeName("HRESULT")]
            int get_systemId(VARIANT* systemID);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_publicId;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_systemId;
        }
    }

    [Guid("2933BF8D-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMEntity : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMEntity : IXMLDOMEntity.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMEntity));

        public Vtbl<IXMLDOMEntity>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMEntity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMEntity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMEntity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMEntity*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMEntity*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMEntity*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMEntity*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMEntity*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMEntity*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMEntity*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMEntity*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMEntity*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMEntity*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMEntity*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMEntity*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMEntity*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMEntity*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMEntity*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMEntity*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMEntity*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMEntity*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMEntity*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMEntity*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMEntity*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMEntity*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMEntity*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMEntity*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMEntity*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMEntity*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMEntity*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMEntity*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMEntity*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMEntity*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMEntity*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_publicId(VARIANT* publicID)
        {
            return lpVtbl->get_publicId((IXMLDOMEntity*)Unsafe.AsPointer(ref this), publicID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemId(VARIANT* systemID)
        {
            return lpVtbl->get_systemId((IXMLDOMEntity*)Unsafe.AsPointer(ref this), systemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_notationName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_notationName((IXMLDOMEntity*)Unsafe.AsPointer(ref this), name);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_publicId(VARIANT* publicID);

            [return: NativeTypeName("HRESULT")]
            int get_systemId(VARIANT* systemID);

            [return: NativeTypeName("HRESULT")]
            int get_notationName([NativeTypeName("BSTR *")] char** name);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_publicId;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_systemId;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_notationName;
        }
    }

    [Guid("2933BF8E-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMEntityReference : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMEntityReference : IXMLDOMEntityReference.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMEntityReference));

        public Vtbl<IXMLDOMEntityReference>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMEntityReference*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
        }
    }

    [Guid("3EFAA426-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct IXMLDOMParseError : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMParseError : IXMLDOMParseError.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMParseError));

        public Vtbl<IXMLDOMParseError>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMParseError*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMParseError*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMParseError*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_errorCode([NativeTypeName("long *")] int* errorCode)
        {
            return lpVtbl->get_errorCode((IXMLDOMParseError*)Unsafe.AsPointer(ref this), errorCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] char** urlString)
        {
            return lpVtbl->get_url((IXMLDOMParseError*)Unsafe.AsPointer(ref this), urlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_reason([NativeTypeName("BSTR *")] char** reasonString)
        {
            return lpVtbl->get_reason((IXMLDOMParseError*)Unsafe.AsPointer(ref this), reasonString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcText([NativeTypeName("BSTR *")] char** sourceString)
        {
            return lpVtbl->get_srcText((IXMLDOMParseError*)Unsafe.AsPointer(ref this), sourceString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_line([NativeTypeName("long *")] int* lineNumber)
        {
            return lpVtbl->get_line((IXMLDOMParseError*)Unsafe.AsPointer(ref this), lineNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_linepos([NativeTypeName("long *")] int* linePosition)
        {
            return lpVtbl->get_linepos((IXMLDOMParseError*)Unsafe.AsPointer(ref this), linePosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_filepos([NativeTypeName("long *")] int* filePosition)
        {
            return lpVtbl->get_filepos((IXMLDOMParseError*)Unsafe.AsPointer(ref this), filePosition);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_errorCode([NativeTypeName("long *")] int* errorCode);

            [return: NativeTypeName("HRESULT")]
            int get_url([NativeTypeName("BSTR *")] char** urlString);

            [return: NativeTypeName("HRESULT")]
            int get_reason([NativeTypeName("BSTR *")] char** reasonString);

            [return: NativeTypeName("HRESULT")]
            int get_srcText([NativeTypeName("BSTR *")] char** sourceString);

            [return: NativeTypeName("HRESULT")]
            int get_line([NativeTypeName("long *")] int* lineNumber);

            [return: NativeTypeName("HRESULT")]
            int get_linepos([NativeTypeName("long *")] int* linePosition);

            [return: NativeTypeName("HRESULT")]
            int get_filepos([NativeTypeName("long *")] int* filePosition);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_errorCode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_url;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_reason;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_srcText;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_line;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_linepos;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_filepos;
        }
    }

    [Guid("3EFAA425-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct IXTLRuntime : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXTLRuntime : IXTLRuntime.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXTLRuntime));

        public Vtbl<IXTLRuntime>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXTLRuntime*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXTLRuntime*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXTLRuntime*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] char** name)
        {
            return lpVtbl->get_nodeName((IXTLRuntime*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] tagDOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXTLRuntime*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXTLRuntime*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXTLRuntime*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXTLRuntime*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXTLRuntime*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXTLRuntime*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXTLRuntime*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXTLRuntime*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXTLRuntime*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXTLRuntime*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXTLRuntime*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXTLRuntime*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] char** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXTLRuntime*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** text)
        {
            return lpVtbl->get_text((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* text)
        {
            return lpVtbl->put_text((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXTLRuntime*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXTLRuntime*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] char* dataTypeName)
        {
            return lpVtbl->put_dataType((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->get_xml((IXTLRuntime*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] char** xmlString)
        {
            return lpVtbl->transformNode((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] char* queryString, IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] char* queryString, IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXTLRuntime*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] char** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXTLRuntime*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] char** prefixString)
        {
            return lpVtbl->get_prefix((IXTLRuntime*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] char** nameString)
        {
            return lpVtbl->get_baseName((IXTLRuntime*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int uniqueID(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pID)
        {
            return lpVtbl->uniqueID((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int depth(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pDepth)
        {
            return lpVtbl->depth((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int childNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return lpVtbl->childNumber((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ancestorChildNumber([NativeTypeName("BSTR")] char* bstrNodeName, IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return lpVtbl->ancestorChildNumber((IXTLRuntime*)Unsafe.AsPointer(ref this), bstrNodeName, pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int absoluteChildNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return lpVtbl->absoluteChildNumber((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatIndex([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR")] char* bstrFormat, [NativeTypeName("BSTR *")] char** pbstrFormattedString)
        {
            return lpVtbl->formatIndex((IXTLRuntime*)Unsafe.AsPointer(ref this), lIndex, bstrFormat, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatNumber(double dblNumber, [NativeTypeName("BSTR")] char* bstrFormat, [NativeTypeName("BSTR *")] char** pbstrFormattedString)
        {
            return lpVtbl->formatNumber((IXTLRuntime*)Unsafe.AsPointer(ref this), dblNumber, bstrFormat, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatDate(VARIANT varDate, [NativeTypeName("BSTR")] char* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] char** pbstrFormattedString)
        {
            return lpVtbl->formatDate((IXTLRuntime*)Unsafe.AsPointer(ref this), varDate, bstrFormat, varDestLocale, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatTime(VARIANT varTime, [NativeTypeName("BSTR")] char* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] char** pbstrFormattedString)
        {
            return lpVtbl->formatTime((IXTLRuntime*)Unsafe.AsPointer(ref this), varTime, bstrFormat, varDestLocale, pbstrFormattedString);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int uniqueID(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pID);

            [return: NativeTypeName("HRESULT")]
            int depth(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pDepth);

            [return: NativeTypeName("HRESULT")]
            int childNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber);

            [return: NativeTypeName("HRESULT")]
            int ancestorChildNumber([NativeTypeName("BSTR")] char* bstrNodeName, IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber);

            [return: NativeTypeName("HRESULT")]
            int absoluteChildNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber);

            [return: NativeTypeName("HRESULT")]
            int formatIndex([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR")] char* bstrFormat, [NativeTypeName("BSTR *")] char** pbstrFormattedString);

            [return: NativeTypeName("HRESULT")]
            int formatNumber(double dblNumber, [NativeTypeName("BSTR")] char* bstrFormat, [NativeTypeName("BSTR *")] char** pbstrFormattedString);

            [return: NativeTypeName("HRESULT")]
            int formatDate(VARIANT varDate, [NativeTypeName("BSTR")] char* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] char** pbstrFormattedString);

            [return: NativeTypeName("HRESULT")]
            int formatTime(VARIANT varTime, [NativeTypeName("BSTR")] char* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] char** pbstrFormattedString);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagDOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, char**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (IXMLDOMNode *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, int*, int> uniqueID;

            [NativeTypeName("HRESULT (IXMLDOMNode *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, int*, int> depth;

            [NativeTypeName("HRESULT (IXMLDOMNode *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, int*, int> childNumber;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLDOMNode*, int*, int> ancestorChildNumber;

            [NativeTypeName("HRESULT (IXMLDOMNode *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMNode*, int*, int> absoluteChildNumber;

            [NativeTypeName("HRESULT (long, BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, char**, int> formatIndex;

            [NativeTypeName("HRESULT (double, BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, char*, char**, int> formatNumber;

            [NativeTypeName("HRESULT (VARIANT, BSTR, VARIANT, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, char*, VARIANT, char**, int> formatDate;

            [NativeTypeName("HRESULT (VARIANT, BSTR, VARIANT, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, char*, VARIANT, char**, int> formatTime;
        }
    }

    [Guid("3EFAA427-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct XMLDOMDocumentEvents : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct XMLDOMDocumentEvents : XMLDOMDocumentEvents.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_XMLDOMDocumentEvents));

        public Vtbl<XMLDOMDocumentEvents>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((XMLDOMDocumentEvents*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        public interface Interface : IDispatch.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;
        }
    }

    [Guid("2933BF90-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct DOMDocument : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_DOMDocument));
    }

    [Guid("2933BF91-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct DOMFreeThreadedDocument : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_DOMFreeThreadedDocument));
    }

    [Guid("ED8C108D-4349-11D2-91A4-00C04F7969E8")]
    [NativeTypeName("struct IXMLHttpRequest : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLHttpRequest : IXMLHttpRequest.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLHttpRequest));

        public Vtbl<IXMLHttpRequest>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] char* bstrMethod, [NativeTypeName("BSTR")] char* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword)
        {
            return lpVtbl->open((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setRequestHeader([NativeTypeName("BSTR")] char* bstrHeader, [NativeTypeName("BSTR")] char* bstrValue)
        {
            return lpVtbl->setRequestHeader((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getResponseHeader([NativeTypeName("BSTR")] char* bstrHeader, [NativeTypeName("BSTR *")] char** pbstrValue)
        {
            return lpVtbl->getResponseHeader((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, pbstrValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getAllResponseHeaders([NativeTypeName("BSTR *")] char** pbstrHeaders)
        {
            return lpVtbl->getAllResponseHeaders((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int send(VARIANT varBody)
        {
            return lpVtbl->send((IXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return lpVtbl->abort((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("long *")] int* plStatus)
        {
            return lpVtbl->get_status((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_statusText([NativeTypeName("BSTR *")] char** pbstrStatus)
        {
            return lpVtbl->get_statusText((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseXML(IDispatch** ppBody)
        {
            return lpVtbl->get_responseXML((IXMLHttpRequest*)Unsafe.AsPointer(ref this), ppBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseText([NativeTypeName("BSTR *")] char** pbstrBody)
        {
            return lpVtbl->get_responseText((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseBody(VARIANT* pvarBody)
        {
            return lpVtbl->get_responseBody((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseStream(VARIANT* pvarBody)
        {
            return lpVtbl->get_responseStream((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* plState)
        {
            return lpVtbl->get_readyState((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(IDispatch* pReadyStateSink)
        {
            return lpVtbl->put_onreadystatechange((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pReadyStateSink);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int open([NativeTypeName("BSTR")] char* bstrMethod, [NativeTypeName("BSTR")] char* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword);

            [return: NativeTypeName("HRESULT")]
            int setRequestHeader([NativeTypeName("BSTR")] char* bstrHeader, [NativeTypeName("BSTR")] char* bstrValue);

            [return: NativeTypeName("HRESULT")]
            int getResponseHeader([NativeTypeName("BSTR")] char* bstrHeader, [NativeTypeName("BSTR *")] char** pbstrValue);

            [return: NativeTypeName("HRESULT")]
            int getAllResponseHeaders([NativeTypeName("BSTR *")] char** pbstrHeaders);

            [return: NativeTypeName("HRESULT")]
            int send(VARIANT varBody);

            [return: NativeTypeName("HRESULT")]
            int abort();

            [return: NativeTypeName("HRESULT")]
            int get_status([NativeTypeName("long *")] int* plStatus);

            [return: NativeTypeName("HRESULT")]
            int get_statusText([NativeTypeName("BSTR *")] char** pbstrStatus);

            [return: NativeTypeName("HRESULT")]
            int get_responseXML(IDispatch** ppBody);

            [return: NativeTypeName("HRESULT")]
            int get_responseText([NativeTypeName("BSTR *")] char** pbstrBody);

            [return: NativeTypeName("HRESULT")]
            int get_responseBody(VARIANT* pvarBody);

            [return: NativeTypeName("HRESULT")]
            int get_responseStream(VARIANT* pvarBody);

            [return: NativeTypeName("HRESULT")]
            int get_readyState([NativeTypeName("long *")] int* plState);

            [return: NativeTypeName("HRESULT")]
            int put_onreadystatechange(IDispatch* pReadyStateSink);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT, VARIANT, VARIANT, int> open;

            [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> setRequestHeader;

            [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> getResponseHeader;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> getAllResponseHeaders;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> send;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> abort;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_status;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_statusText;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch**, int> get_responseXML;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_responseText;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_responseBody;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_responseStream;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch*, int> put_onreadystatechange;
        }
    }

    [Guid("ED8C108E-4349-11D2-91A4-00C04F7969E8")]
    public unsafe partial struct XMLHTTPRequest : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_XMLHTTPRequest));
    }

    [Guid("310AFA62-0575-11D2-9CA9-0060B0EC3D39")]
    [NativeTypeName("struct IXMLDSOControl : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDSOControl : IXMLDSOControl.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDSOControl));

        public Vtbl<IXMLDSOControl>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDSOControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDSOControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDSOControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_XMLDocument(IXMLDOMDocument** ppDoc)
        {
            return lpVtbl->get_XMLDocument((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_XMLDocument(IXMLDOMDocument* ppDoc)
        {
            return lpVtbl->put_XMLDocument((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_JavaDSOCompatible([NativeTypeName("BOOL *")] int* fJavaDSOCompatible)
        {
            return lpVtbl->get_JavaDSOCompatible((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_JavaDSOCompatible([NativeTypeName("BOOL")] int fJavaDSOCompatible)
        {
            return lpVtbl->put_JavaDSOCompatible((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* state)
        {
            return lpVtbl->get_readyState((IXMLDSOControl*)Unsafe.AsPointer(ref this), state);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_XMLDocument(IXMLDOMDocument** ppDoc);

            [return: NativeTypeName("HRESULT")]
            int put_XMLDocument(IXMLDOMDocument* ppDoc);

            [return: NativeTypeName("HRESULT")]
            int get_JavaDSOCompatible([NativeTypeName("BOOL *")] int* fJavaDSOCompatible);

            [return: NativeTypeName("HRESULT")]
            int put_JavaDSOCompatible([NativeTypeName("BOOL")] int fJavaDSOCompatible);

            [return: NativeTypeName("HRESULT")]
            int get_readyState([NativeTypeName("long *")] int* state);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument**, int> get_XMLDocument;

            [NativeTypeName("HRESULT (IXMLDOMDocument *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLDOMDocument*, int> put_XMLDocument;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_JavaDSOCompatible;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_JavaDSOCompatible;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_readyState;
        }
    }

    [Guid("550DDA30-0541-11D2-9CA9-0060B0EC3D39")]
    public unsafe partial struct XMLDSOControl : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_XMLDSOControl));
    }

    [Guid("65725580-9B5D-11D0-9BFE-00C04FC99C8E")]
    [NativeTypeName("struct IXMLElementCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLElementCollection : IXMLElementCollection.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLElementCollection));

        public Vtbl<IXMLElementCollection>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLElementCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLElementCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLElementCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLElementCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLElementCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLElementCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLElementCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_length([NativeTypeName("long")] int v)
        {
            return lpVtbl->put_length((IXMLElementCollection*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return lpVtbl->get_length((IXMLElementCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** ppUnk)
        {
            return lpVtbl->get__newEnum((IXMLElementCollection*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int item(VARIANT var1, VARIANT var2, IDispatch** ppDisp)
        {
            return lpVtbl->item((IXMLElementCollection*)Unsafe.AsPointer(ref this), var1, var2, ppDisp);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int put_length([NativeTypeName("long")] int v);

            [return: NativeTypeName("HRESULT")]
            int get_length([NativeTypeName("long *")] int* p);

            [return: NativeTypeName("HRESULT")]
            int get__newEnum(IUnknown** ppUnk);

            [return: NativeTypeName("HRESULT")]
            int item(VARIANT var1, VARIANT var2, IDispatch** ppDisp);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_length;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown**, int> get__newEnum;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, IDispatch**, int> item;
        }
    }

    [Guid("F52E2B61-18A1-11D1-B105-00805F49916B")]
    [NativeTypeName("struct IXMLDocument : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDocument : IXMLDocument.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDocument));

        public Vtbl<IXMLDocument>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_root(IXMLElement** p)
        {
            return lpVtbl->get_root((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileSize((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileModifiedDate((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileUpdatedDate((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_URL((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_URL((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_mimeType((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return lpVtbl->get_readyState((IXMLDocument*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_charset((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_charset((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_version((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_doctype((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_dtdURL((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, IXMLElement** ppElem)
        {
            return lpVtbl->createElement((IXMLDocument*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_root(IXMLElement** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileSize([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileModifiedDate([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileUpdatedDate([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_URL([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_URL([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_mimeType([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_readyState([NativeTypeName("long *")] int* pl);

            [return: NativeTypeName("HRESULT")]
            int get_charset([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_charset([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_version([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_doctype([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_dtdURL([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int createElement(VARIANT vType, VARIANT var1, IXMLElement** ppElem);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement**, int> get_root;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileModifiedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileUpdatedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_URL;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_mimeType;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_charset;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_charset;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_version;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_doctype;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_dtdURL;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, IXMLElement**, int> createElement;
        }
    }

    [Guid("2B8DE2FE-8D2D-11D1-B2FC-00C04FD915A9")]
    [NativeTypeName("struct IXMLDocument2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDocument2 : IXMLDocument2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDocument2));

        public Vtbl<IXMLDocument2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_root(IXMLElement2** p)
        {
            return lpVtbl->get_root((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileSize((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileModifiedDate((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_fileUpdatedDate((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_URL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_URL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_mimeType((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return lpVtbl->get_readyState((IXMLDocument2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_charset((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_charset((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_version((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_doctype((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_dtdURL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, IXMLElement2** ppElem)
        {
            return lpVtbl->createElement((IXMLDocument2*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* pf)
        {
            return lpVtbl->get_async((IXMLDocument2*)Unsafe.AsPointer(ref this), pf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short f)
        {
            return lpVtbl->put_async((IXMLDocument2*)Unsafe.AsPointer(ref this), f);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_root(IXMLElement2** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileSize([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileModifiedDate([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_fileUpdatedDate([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_URL([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_URL([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_mimeType([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_readyState([NativeTypeName("long *")] int* pl);

            [return: NativeTypeName("HRESULT")]
            int get_charset([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_charset([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_version([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_doctype([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int get_dtdURL([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int createElement(VARIANT vType, VARIANT var1, IXMLElement2** ppElem);

            [return: NativeTypeName("HRESULT")]
            int get_async([NativeTypeName("VARIANT_BOOL *")] short* pf);

            [return: NativeTypeName("HRESULT")]
            int put_async([NativeTypeName("VARIANT_BOOL")] short f);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement2**, int> get_root;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileModifiedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileUpdatedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_URL;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_mimeType;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_charset;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_charset;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_version;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_doctype;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_dtdURL;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, IXMLElement2**, int> createElement;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_async;
        }
    }

    [Guid("3F7F31AC-E15F-11D0-9C25-00C04FC99C8E")]
    [NativeTypeName("struct IXMLElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLElement : IXMLElement.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLElement));

        public Vtbl<IXMLElement>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_tagName((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_tagName((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parent(IXMLElement** ppParent)
        {
            return lpVtbl->get_parent((IXMLElement*)Unsafe.AsPointer(ref this), ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT PropertyValue)
        {
            return lpVtbl->setAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT* PropertyValue)
        {
            return lpVtbl->getAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] char* strPropertyName)
        {
            return lpVtbl->removeAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_children(IXMLElementCollection** pp)
        {
            return lpVtbl->get_children((IXMLElement*)Unsafe.AsPointer(ref this), pp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return lpVtbl->get_type((IXMLElement*)Unsafe.AsPointer(ref this), plType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_text((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_text((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int addChild(IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return lpVtbl->addChild((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLElement* pChildElem)
        {
            return lpVtbl->removeChild((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_tagName([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_tagName([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_parent(IXMLElement** ppParent);

            [return: NativeTypeName("HRESULT")]
            int setAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT PropertyValue);

            [return: NativeTypeName("HRESULT")]
            int getAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT* PropertyValue);

            [return: NativeTypeName("HRESULT")]
            int removeAttribute([NativeTypeName("BSTR")] char* strPropertyName);

            [return: NativeTypeName("HRESULT")]
            int get_children(IXMLElementCollection** pp);

            [return: NativeTypeName("HRESULT")]
            int get_type([NativeTypeName("long *")] int* plType);

            [return: NativeTypeName("HRESULT")]
            int get_text([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_text([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int addChild(IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved);

            [return: NativeTypeName("HRESULT")]
            int removeChild(IXMLElement* pChildElem);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_tagName;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_tagName;

            [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement**, int> get_parent;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> setAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> removeAttribute;

            [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElementCollection**, int> get_children;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_type;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (IXMLElement *, long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement*, int, int, int> addChild;

            [NativeTypeName("HRESULT (IXMLElement *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement*, int> removeChild;
        }
    }

    [Guid("2B8DE2FF-8D2D-11D1-B2FC-00C04FD915A9")]
    [NativeTypeName("struct IXMLElement2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLElement2 : IXMLElement2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLElement2));

        public Vtbl<IXMLElement2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLElement2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_tagName((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_tagName((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parent(IXMLElement2** ppParent)
        {
            return lpVtbl->get_parent((IXMLElement2*)Unsafe.AsPointer(ref this), ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT PropertyValue)
        {
            return lpVtbl->setAttribute((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT* PropertyValue)
        {
            return lpVtbl->getAttribute((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] char* strPropertyName)
        {
            return lpVtbl->removeAttribute((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_children(IXMLElementCollection** pp)
        {
            return lpVtbl->get_children((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return lpVtbl->get_type((IXMLElement2*)Unsafe.AsPointer(ref this), plType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] char** p)
        {
            return lpVtbl->get_text((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] char* p)
        {
            return lpVtbl->put_text((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int addChild(IXMLElement2* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return lpVtbl->addChild((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLElement2* pChildElem)
        {
            return lpVtbl->removeChild((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLElementCollection** pp)
        {
            return lpVtbl->get_attributes((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_tagName([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_tagName([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int get_parent(IXMLElement2** ppParent);

            [return: NativeTypeName("HRESULT")]
            int setAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT PropertyValue);

            [return: NativeTypeName("HRESULT")]
            int getAttribute([NativeTypeName("BSTR")] char* strPropertyName, VARIANT* PropertyValue);

            [return: NativeTypeName("HRESULT")]
            int removeAttribute([NativeTypeName("BSTR")] char* strPropertyName);

            [return: NativeTypeName("HRESULT")]
            int get_children(IXMLElementCollection** pp);

            [return: NativeTypeName("HRESULT")]
            int get_type([NativeTypeName("long *")] int* plType);

            [return: NativeTypeName("HRESULT")]
            int get_text([NativeTypeName("BSTR *")] char** p);

            [return: NativeTypeName("HRESULT")]
            int put_text([NativeTypeName("BSTR")] char* p);

            [return: NativeTypeName("HRESULT")]
            int addChild(IXMLElement2* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved);

            [return: NativeTypeName("HRESULT")]
            int removeChild(IXMLElement2* pChildElem);

            [return: NativeTypeName("HRESULT")]
            int get_attributes(IXMLElementCollection** pp);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_tagName;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_tagName;

            [NativeTypeName("HRESULT (IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement2**, int> get_parent;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> setAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> removeAttribute;

            [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElementCollection**, int> get_children;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_type;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_text;

            [NativeTypeName("HRESULT (IXMLElement2 *, long, long) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement2*, int, int, int> addChild;

            [NativeTypeName("HRESULT (IXMLElement2 *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElement2*, int> removeChild;

            [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IXMLElementCollection**, int> get_attributes;
        }
    }

    [Guid("D4D4A0FC-3B73-11D1-B2B4-00C04FB92596")]
    [NativeTypeName("struct IXMLAttribute : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLAttribute : IXMLAttribute.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLAttribute));

        public Vtbl<IXMLAttribute>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLAttribute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLAttribute*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLAttribute*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLAttribute*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLAttribute*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] char** n)
        {
            return lpVtbl->get_name((IXMLAttribute*)Unsafe.AsPointer(ref this), n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_value([NativeTypeName("BSTR *")] char** v)
        {
            return lpVtbl->get_value((IXMLAttribute*)Unsafe.AsPointer(ref this), v);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int get_name([NativeTypeName("BSTR *")] char** n);

            [return: NativeTypeName("HRESULT")]
            int get_value([NativeTypeName("BSTR *")] char** v);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_name;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_value;
        }
    }

    [Guid("948C5AD3-C58D-11D0-9C0B-00C04FC99C8E")]
    [NativeTypeName("struct IXMLError : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IXMLError : IXMLError.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLError));

        public Vtbl<IXMLError>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorInfo([NativeTypeName("XML_ERROR *")] _xml_error* pErrorReturn)
        {
            return lpVtbl->GetErrorInfo((IXMLError*)Unsafe.AsPointer(ref this), pErrorReturn);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetErrorInfo([NativeTypeName("XML_ERROR *")] _xml_error* pErrorReturn);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (XML_ERROR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, _xml_error*, int> GetErrorInfo;
        }
    }

    [Guid("CFC399AF-D876-11D0-9C10-00C04FC99C8E")]
    public unsafe partial struct XMLDocument : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_XMLDocument));
    }

    public static partial class Methods
    {
        public static ref readonly Guid IID_IXMLDOMImplementation
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8F, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMNode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x80, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMDocumentFragment
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x13, 0xA4, 0xFA, 0x3E,
                    0x2F, 0x27,
                    0xD2, 0x11,
                    0x83,
                    0x6F,
                    0x00,
                    0x00,
                    0xF8,
                    0x7A,
                    0x77,
                    0x82
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMDocument
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x81, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMNodeList
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x82, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMNamedNodeMap
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x83, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMCharacterData
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x84, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMAttribute
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x85, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMElement
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x86, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMText
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x87, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMComment
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x88, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMProcessingInstruction
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x89, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMCDATASection
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8A, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMDocumentType
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8B, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMNotation
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8C, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMEntity
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8D, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMEntityReference
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8E, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDOMParseError
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x26, 0xA4, 0xFA, 0x3E,
                    0x2F, 0x27,
                    0xD2, 0x11,
                    0x83,
                    0x6F,
                    0x00,
                    0x00,
                    0xF8,
                    0x7A,
                    0x77,
                    0x82
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXTLRuntime
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x25, 0xA4, 0xFA, 0x3E,
                    0x2F, 0x27,
                    0xD2, 0x11,
                    0x83,
                    0x6F,
                    0x00,
                    0x00,
                    0xF8,
                    0x7A,
                    0x77,
                    0x82
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_XMLDOMDocumentEvents
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x27, 0xA4, 0xFA, 0x3E,
                    0x2F, 0x27,
                    0xD2, 0x11,
                    0x83,
                    0x6F,
                    0x00,
                    0x00,
                    0xF8,
                    0x7A,
                    0x77,
                    0x82
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DOMDocument
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x90, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DOMFreeThreadedDocument
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x91, 0xBF, 0x33, 0x29,
                    0x36, 0x7B,
                    0xD2, 0x11,
                    0xB2,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x98,
                    0x3E,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLHttpRequest
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8D, 0x10, 0x8C, 0xED,
                    0x49, 0x43,
                    0xD2, 0x11,
                    0x91,
                    0xA4,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x69,
                    0xE8
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_XMLHTTPRequest
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8E, 0x10, 0x8C, 0xED,
                    0x49, 0x43,
                    0xD2, 0x11,
                    0x91,
                    0xA4,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x69,
                    0xE8
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDSOControl
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x62, 0xFA, 0x0A, 0x31,
                    0x75, 0x05,
                    0xD2, 0x11,
                    0x9C,
                    0xA9,
                    0x00,
                    0x60,
                    0xB0,
                    0xEC,
                    0x3D,
                    0x39
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_XMLDSOControl
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x30, 0xDA, 0x0D, 0x55,
                    0x41, 0x05,
                    0xD2, 0x11,
                    0x9C,
                    0xA9,
                    0x00,
                    0x60,
                    0xB0,
                    0xEC,
                    0x3D,
                    0x39
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLElementCollection
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x80, 0x55, 0x72, 0x65,
                    0x5D, 0x9B,
                    0xD0, 0x11,
                    0x9B,
                    0xFE,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC9,
                    0x9C,
                    0x8E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDocument
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x61, 0x2B, 0x2E, 0xF5,
                    0xA1, 0x18,
                    0xD1, 0x11,
                    0xB1,
                    0x05,
                    0x00,
                    0x80,
                    0x5F,
                    0x49,
                    0x91,
                    0x6B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLDocument2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xFE, 0xE2, 0x8D, 0x2B,
                    0x2D, 0x8D,
                    0xD1, 0x11,
                    0xB2,
                    0xFC,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x15,
                    0xA9
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLElement
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xAC, 0x31, 0x7F, 0x3F,
                    0x5F, 0xE1,
                    0xD0, 0x11,
                    0x9C,
                    0x25,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC9,
                    0x9C,
                    0x8E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLElement2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xFF, 0xE2, 0x8D, 0x2B,
                    0x2D, 0x8D,
                    0xD1, 0x11,
                    0xB2,
                    0xFC,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x15,
                    0xA9
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLAttribute
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xFC, 0xA0, 0xD4, 0xD4,
                    0x73, 0x3B,
                    0xD1, 0x11,
                    0xB2,
                    0xB4,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB9,
                    0x25,
                    0x96
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXMLError
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD3, 0x5A, 0x8C, 0x94,
                    0x8D, 0xC5,
                    0xD0, 0x11,
                    0x9C,
                    0x0B,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC9,
                    0x9C,
                    0x8E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_XMLDocument
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xAF, 0x99, 0xC3, 0xCF,
                    0x76, 0xD8,
                    0xD0, 0x11,
                    0x9C,
                    0x10,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC9,
                    0x9C,
                    0x8E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}

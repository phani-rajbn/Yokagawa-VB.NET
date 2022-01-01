// MathComponent.h : Declaration of the CMathComponent

#pragma once
#include "resource.h"       // main symbols



#include "SampleCOMLib_i.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// CMathComponent

class ATL_NO_VTABLE CMathComponent :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CMathComponent, &CLSID_MathComponent>,
	public IDispatchImpl<IMathComponent, &IID_IMathComponent, &LIBID_SampleCOMLibLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	CMathComponent()
	{
	}

DECLARE_REGISTRY_RESOURCEID(106)


BEGIN_COM_MAP(CMathComponent)
	COM_INTERFACE_ENTRY(IMathComponent)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

	STDMETHOD(AddMethod)(int iVal1, int iVal2, int* iRes) 
	{
		*iRes = iVal1 + iVal2;
		MessageBoxA(NULL, "Sample Example", "Test App", MB_OK);
		return S_OK;
	}
	STDMETHOD(SubtractMethod)(int iVal1, int iVal2, int* iRes)
	{
		MessageBoxA(NULL, "Subtract Example", "Test App", MB_OK);
		*iRes = iVal1 - iVal2;
		return S_OK;
	}

public:



};

OBJECT_ENTRY_AUTO(__uuidof(MathComponent), CMathComponent)

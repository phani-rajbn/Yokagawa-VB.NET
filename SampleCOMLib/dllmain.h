// dllmain.h : Declaration of module class.

class CSampleCOMLibModule : public ATL::CAtlDllModuleT< CSampleCOMLibModule >
{
public :
	DECLARE_LIBID(LIBID_SampleCOMLibLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_SAMPLECOMLIB, "{56721aae-2eb4-4c77-b67f-5541faf544c5}")
};

extern class CSampleCOMLibModule _AtlModule;

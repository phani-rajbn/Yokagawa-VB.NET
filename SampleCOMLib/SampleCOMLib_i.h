

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Tue Jan 19 08:44:07 2038
 */
/* Compiler settings for SampleCOMLib.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.01.0622 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */



/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 500
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif /* __RPCNDR_H_VERSION__ */

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __SampleCOMLib_i_h__
#define __SampleCOMLib_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IMathComponent_FWD_DEFINED__
#define __IMathComponent_FWD_DEFINED__
typedef interface IMathComponent IMathComponent;

#endif 	/* __IMathComponent_FWD_DEFINED__ */


#ifndef __MathComponent_FWD_DEFINED__
#define __MathComponent_FWD_DEFINED__

#ifdef __cplusplus
typedef class MathComponent MathComponent;
#else
typedef struct MathComponent MathComponent;
#endif /* __cplusplus */

#endif 	/* __MathComponent_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"
#include "shobjidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IMathComponent_INTERFACE_DEFINED__
#define __IMathComponent_INTERFACE_DEFINED__

/* interface IMathComponent */
/* [unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMathComponent;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("438608b0-a842-4b3c-8e84-291eff71a3af")
    IMathComponent : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddMethod( 
            int iVal1,
            int iVal2,
            int *iRes) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SubtractMethod( 
            int iVal1,
            int iVal2,
            int *iRes) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IMathComponentVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMathComponent * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMathComponent * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMathComponent * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IMathComponent * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IMathComponent * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IMathComponent * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IMathComponent * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddMethod )( 
            IMathComponent * This,
            int iVal1,
            int iVal2,
            int *iRes);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SubtractMethod )( 
            IMathComponent * This,
            int iVal1,
            int iVal2,
            int *iRes);
        
        END_INTERFACE
    } IMathComponentVtbl;

    interface IMathComponent
    {
        CONST_VTBL struct IMathComponentVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMathComponent_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IMathComponent_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IMathComponent_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IMathComponent_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IMathComponent_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IMathComponent_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IMathComponent_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IMathComponent_AddMethod(This,iVal1,iVal2,iRes)	\
    ( (This)->lpVtbl -> AddMethod(This,iVal1,iVal2,iRes) ) 

#define IMathComponent_SubtractMethod(This,iVal1,iVal2,iRes)	\
    ( (This)->lpVtbl -> SubtractMethod(This,iVal1,iVal2,iRes) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IMathComponent_INTERFACE_DEFINED__ */



#ifndef __SampleCOMLibLib_LIBRARY_DEFINED__
#define __SampleCOMLibLib_LIBRARY_DEFINED__

/* library SampleCOMLibLib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_SampleCOMLibLib;

EXTERN_C const CLSID CLSID_MathComponent;

#ifdef __cplusplus

class DECLSPEC_UUID("2f6c1b60-9325-44d3-9e7a-6e2102ce5b59")
MathComponent;
#endif
#endif /* __SampleCOMLibLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif



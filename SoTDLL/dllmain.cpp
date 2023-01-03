// dllmain.cpp : Defines the entry point for the DLL application.
#include <Windows.h>
#include "processtools.h"
#include "patternscan.h"
#include "memhack.h"
#include <iostream>

DWORD WINAPI OnDllAttach(LPVOID base) {

    DWORD processID = GetProcID(L"SoTGame.exe");
    //Get handle by OpenProcess
    HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, processID);

    //PatternScan
    uintptr_t* GObjects = reinterpret_cast<uintptr_t*>(PatternScanExModule(hProcess, L"SoTGame.exe", L"SoTGame.exe", "\x89\x0D\x00\x00\x00\x00\x48\x8B\xDF\x48\x89\x5C\x24", "xx????xxxxxxx"));

    return TRUE;
}

DWORD WINAPI OnDllDetach()
{
    return TRUE;
}

BOOL WINAPI DllMain(_In_ HINSTANCE hinstDll, _In_ DWORD fdwReason,
    _In_opt_ LPVOID lpvReserved) {
    switch (fdwReason) {
    case DLL_PROCESS_ATTACH:
        DisableThreadLibraryCalls(hinstDll);
        CreateThread(nullptr, 0, OnDllAttach, hinstDll, 0, nullptr);
        return TRUE;
    case DLL_PROCESS_DETACH:
        if (lpvReserved == nullptr) return OnDllDetach();
        return TRUE;
    default:
        return TRUE;
    }
}

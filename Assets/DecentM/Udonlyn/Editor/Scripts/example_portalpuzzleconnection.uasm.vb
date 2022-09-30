.data_start
    .export signage
    .export gate
    .export startEnabled
    .export output
    .export inputs
    .sync _outputState, none
    __refl_typeid: %SystemInt64, null
    __refl_typename: %SystemString, null
    __intnl_returnJump_SystemUInt32_0: %SystemUInt32, null
    signage: %SystemInt32, null
    gate: %SystemInt32, null
    startEnabled: %SystemBoolean, null
    output: %VRCUdonUdonBehaviour, null
    inputs: %UnityEngineComponentArray, null
    _outputState: %SystemBoolean, null
    isSendingSyncedValue: %SystemBoolean, null
    __0_get_outputState__ret: %SystemBoolean, null
    __const_SystemUInt32_0: %SystemUInt32, null
    __0_value__param: %SystemBoolean, null
    _old__outputState: %SystemBoolean, null
    __this_UnityEngineGameObject_0: %UnityEngineGameObject, this
    __this_VRCUdonUdonBehaviour_0: %VRCUdonUdonBehaviour, this
    __gintnl_SystemUInt32_0: %SystemUInt32, null
    __const_SystemInt32_0: %SystemInt32, null
    __this_VRCUdonUdonBehaviour_1: %VRCUdonUdonBehaviour, this
    __const_SystemString_0: %SystemString, null
    __const_SystemString_1: %SystemString, null
    __const_SystemString_2: %SystemString, null
    __const_SystemString_3: %SystemString, null
    __const_SystemString_4: %SystemString, null
    __const_SystemInt32_1: %SystemInt32, null
    __this_VRCUdonUdonBehaviour_2: %VRCUdonUdonBehaviour, this
    __gintnl_SystemUInt32_1: %SystemUInt32, null
    __const_SystemInt32_2: %SystemInt32, null
    __gintnl_SystemUInt32_2: %SystemUInt32, null
    __const_SystemInt32_3: %SystemInt32, null
    __gintnl_SystemUInt32_3: %SystemUInt32, null
    __const_SystemString_5: %SystemString, null
    __const_SystemString_6: %SystemString, null
    __gintnl_SystemUInt32_4: %SystemUInt32, null
    __0_result__param: %SystemBoolean, null
    __const_SystemBoolean_0: %SystemBoolean, null
    __gintnl_SystemUInt32_5: %SystemUInt32, null
    __const_SystemBoolean_1: %SystemBoolean, null
    __gintnl_SystemUInt32_6: %SystemUInt32, null
    __gintnl_SystemUInt32_7: %SystemUInt32, null
    __gintnl_SystemUInt32_8: %SystemUInt32, null
    __gintnl_SystemUInt32_9: %SystemUInt32, null
    __gintnl_SystemUInt32_10: %SystemUInt32, null
    __gintnl_SystemUInt32_11: %SystemUInt32, null
    __gintnl_SystemUInt32_12: %SystemUInt32, null
    __const_SystemString_7: %SystemString, null
    __const_SystemString_8: %SystemString, null
    __intnl_VRCSDKBaseVRCPlayerApi_0: %VRCSDKBaseVRCPlayerApi, null
    __intnl_VRCSDKBaseVRCPlayerApi_1: %VRCSDKBaseVRCPlayerApi, null
    __intnl_SystemBoolean_0: %SystemBoolean, null
    __intnl_VRCSDKBaseVRCPlayerApi_2: %VRCSDKBaseVRCPlayerApi, null
    __intnl_SystemInt32_0: %SystemInt32, null
    __intnl_SystemBoolean_1: %SystemBoolean, null
    __intnl_SystemObject_0: %SystemObject, null
    __intnl_SystemInt32_1: %SystemInt32, null
    __lcl_input_VRCUdonUdonBehaviour_0: %VRCUdonUdonBehaviour, null
    __intnl_SystemInt32_2: %SystemInt32, null
    __intnl_SystemBoolean_2: %SystemBoolean, null
    __intnl_SystemBoolean_3: %SystemBoolean, null
    __intnl_SystemBoolean_4: %SystemBoolean, null
    __intnl_SystemInt32_3: %SystemInt32, null
    __intnl_SystemInt32_4: %SystemInt32, null
    __intnl_SystemBoolean_5: %SystemBoolean, null
    __lcl_input_VRCUdonUdonBehaviour_1: %VRCUdonUdonBehaviour, null
    __intnl_SystemBoolean_6: %SystemBoolean, null
    __intnl_SystemObject_1: %SystemObject, null
    __intnl_SystemInt32_5: %SystemInt32, null
    __intnl_SystemInt32_6: %SystemInt32, null
    __intnl_SystemBoolean_7: %SystemBoolean, null
    __lcl_input_VRCUdonUdonBehaviour_2: %VRCUdonUdonBehaviour, null
    __intnl_SystemBoolean_8: %SystemBoolean, null
    __intnl_SystemObject_2: %SystemObject, null
    __intnl_VRCUdonUdonBehaviour_0: %VRCUdonUdonBehaviour, null
    __intnl_VRCUdonUdonBehaviour_1: %VRCUdonUdonBehaviour, null
.data_end
.code_start
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.get
# 
        PUSH, _outputState
        PUSH, __0_get_outputState__ret
        COPY
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
    .export _onVarChange__outputState
    _onVarChange__outputState:
        PUSH, _outputState
        PUSH, __0_value__param
        COPY
        PUSH, _old__outputState
        PUSH, _outputState
        COPY
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.set
# 
        PUSH, __0_value__param
        PUSH, _outputState
        COPY
        PUSH, isSendingSyncedValue
        JUMP_IF_FALSE, 0x00000128
        PUSH, __this_UnityEngineGameObject_0
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_0
        EXTERN, "VRCSDKBaseNetworking.__GetOwner__UnityEngineGameObject__VRCSDKBaseVRCPlayerApi"
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_1
        EXTERN, "VRCSDKBaseNetworking.__get_LocalPlayer__VRCSDKBaseVRCPlayerApi"
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_0
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_1
        PUSH, __intnl_SystemBoolean_0
        EXTERN, "SystemObject.__op_Inequality__SystemObject_SystemObject__SystemBoolean"
        PUSH, __intnl_SystemBoolean_0
        JUMP_IF_FALSE, 0x00000118
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_2
        EXTERN, "VRCSDKBaseNetworking.__get_LocalPlayer__VRCSDKBaseVRCPlayerApi"
        PUSH, __intnl_VRCSDKBaseVRCPlayerApi_2
        PUSH, __this_UnityEngineGameObject_0
        EXTERN, "VRCSDKBaseNetworking.__SetOwner__VRCSDKBaseVRCPlayerApi_UnityEngineGameObject__SystemVoid"
        PUSH, __this_VRCUdonUdonBehaviour_0
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__RequestSerialization__SystemVoid"
        PUSH, __gintnl_SystemUInt32_0
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleOutputStateChange()
        JUMP, 0x00000840
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
    .export _start
    _start:
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.Start()
# 
        PUSH, inputs
        PUSH, __intnl_SystemInt32_0
        EXTERN, "SystemArray.__get_Length__SystemInt32"
        PUSH, __const_SystemInt32_0
        PUSH, __intnl_SystemInt32_1
        COPY
        PUSH, __intnl_SystemInt32_1
        PUSH, __intnl_SystemInt32_0
        PUSH, __intnl_SystemBoolean_1
        EXTERN, "SystemInt32.__op_LessThan__SystemInt32_SystemInt32__SystemBoolean"
        PUSH, __intnl_SystemBoolean_1
        JUMP_IF_FALSE, 0x000002b0
        PUSH, inputs
        PUSH, __intnl_SystemInt32_1
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        EXTERN, "SystemObjectArray.__Get__SystemInt32__SystemObject"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        PUSH, __const_SystemString_0
        PUSH, __this_VRCUdonUdonBehaviour_1
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SetProgramVariable__SystemString_SystemObject__SystemVoid"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        PUSH, __const_SystemString_1
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
# Cow dirty
        PUSH, signage
        PUSH, __intnl_SystemInt32_2
        COPY
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        PUSH, __const_SystemString_2
        PUSH, signage
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SetProgramVariable__SystemString_SystemObject__SystemVoid"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        PUSH, __const_SystemString_3
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_0
        PUSH, __const_SystemString_4
        PUSH, __intnl_SystemObject_0
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__GetProgramVariable__SystemString__SystemObject"
        PUSH, __intnl_SystemObject_0
        PUSH, __intnl_SystemBoolean_2
        COPY
        PUSH, __intnl_SystemInt32_1
        PUSH, __const_SystemInt32_1
        PUSH, __intnl_SystemInt32_1
        EXTERN, "SystemInt32.__op_Addition__SystemInt32_SystemInt32__SystemInt32"
        JUMP, 0x00000180
        PUSH, output
        PUSH, __const_SystemString_0
        PUSH, __this_VRCUdonUdonBehaviour_2
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SetProgramVariable__SystemString_SystemObject__SystemVoid"
        PUSH, output
        PUSH, __const_SystemString_1
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
# Cow dirty
        PUSH, signage
        PUSH, __intnl_SystemInt32_0
        COPY
        PUSH, output
        PUSH, __const_SystemString_2
        PUSH, signage
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SetProgramVariable__SystemString_SystemObject__SystemVoid"
        PUSH, output
        PUSH, __const_SystemString_3
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        PUSH, output
        PUSH, __const_SystemString_4
        PUSH, __intnl_SystemObject_0
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__GetProgramVariable__SystemString__SystemObject"
        PUSH, __intnl_SystemObject_0
        PUSH, __intnl_SystemBoolean_1
        COPY
        PUSH, __gintnl_SystemUInt32_1
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.OnStateChange()
        JUMP, 0x00000394
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
    .export OnStateChange
    OnStateChange:
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.OnStateChange()
# 
        PUSH, gate
        PUSH, __const_SystemInt32_2
        PUSH, __intnl_SystemBoolean_3
        EXTERN, "SystemInt32.__op_Equality__SystemInt32_SystemInt32__SystemBoolean"
        PUSH, __intnl_SystemBoolean_3
        JUMP_IF_FALSE, 0x000003dc
        PUSH, __gintnl_SystemUInt32_2
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleStateChangeOr()
        JUMP, 0x000005C0
        JUMP, 0x00000424
        PUSH, gate
        PUSH, __const_SystemInt32_3
        PUSH, __intnl_SystemBoolean_4
        EXTERN, "SystemInt32.__op_Equality__SystemInt32_SystemInt32__SystemBoolean"
        PUSH, __intnl_SystemBoolean_4
        JUMP_IF_FALSE, 0x00000424
        PUSH, __gintnl_SystemUInt32_3
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleStateChangeAnd()
        JUMP, 0x00000440
        JUMP, 0x00000424
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleStateChangeAnd()
# 
        PUSH, inputs
        PUSH, __intnl_SystemInt32_3
        EXTERN, "SystemArray.__get_Length__SystemInt32"
        PUSH, __const_SystemInt32_0
        PUSH, __intnl_SystemInt32_4
        COPY
        PUSH, __intnl_SystemInt32_4
        PUSH, __intnl_SystemInt32_3
        PUSH, __intnl_SystemBoolean_5
        EXTERN, "SystemInt32.__op_LessThan__SystemInt32_SystemInt32__SystemBoolean"
        PUSH, __intnl_SystemBoolean_5
        JUMP_IF_FALSE, 0x00000580
        PUSH, inputs
        PUSH, __intnl_SystemInt32_4
        PUSH, __lcl_input_VRCUdonUdonBehaviour_1
        EXTERN, "SystemObjectArray.__Get__SystemInt32__SystemObject"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_1
        PUSH, __const_SystemString_5
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_1
        PUSH, __const_SystemString_6
        PUSH, __intnl_SystemObject_1
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__GetProgramVariable__SystemString__SystemObject"
        PUSH, __intnl_SystemObject_1
        PUSH, __intnl_SystemBoolean_6
        COPY
        PUSH, __intnl_SystemBoolean_6
        JUMP_IF_FALSE, 0x00000520
        JUMP, 0x00000558
        PUSH, __gintnl_SystemUInt32_4
        PUSH, __const_SystemBoolean_0
        PUSH, __0_result__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.GateResult(bool)
        JUMP, 0x00000738
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __intnl_SystemInt32_4
        PUSH, __const_SystemInt32_1
        PUSH, __intnl_SystemInt32_4
        EXTERN, "SystemInt32.__op_Addition__SystemInt32_SystemInt32__SystemInt32"
        JUMP, 0x0000046C
        PUSH, __gintnl_SystemUInt32_5
        PUSH, __const_SystemBoolean_1
        PUSH, __0_result__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.GateResult(bool)
        JUMP, 0x00000738
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleStateChangeOr()
# 
        PUSH, inputs
        PUSH, __intnl_SystemInt32_5
        EXTERN, "SystemArray.__get_Length__SystemInt32"
        PUSH, __const_SystemInt32_0
        PUSH, __intnl_SystemInt32_6
        COPY
        PUSH, __intnl_SystemInt32_6
        PUSH, __intnl_SystemInt32_5
        PUSH, __intnl_SystemBoolean_7
        EXTERN, "SystemInt32.__op_LessThan__SystemInt32_SystemInt32__SystemBoolean"
        PUSH, __intnl_SystemBoolean_7
        JUMP_IF_FALSE, 0x000006f8
        PUSH, inputs
        PUSH, __intnl_SystemInt32_6
        PUSH, __lcl_input_VRCUdonUdonBehaviour_2
        EXTERN, "SystemObjectArray.__Get__SystemInt32__SystemObject"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_2
        PUSH, __const_SystemString_5
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        PUSH, __lcl_input_VRCUdonUdonBehaviour_2
        PUSH, __const_SystemString_6
        PUSH, __intnl_SystemObject_2
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__GetProgramVariable__SystemString__SystemObject"
        PUSH, __intnl_SystemObject_2
        PUSH, __intnl_SystemBoolean_8
        COPY
        PUSH, __intnl_SystemBoolean_8
        JUMP_IF_FALSE, 0x000006d0
        PUSH, __gintnl_SystemUInt32_6
        PUSH, __const_SystemBoolean_1
        PUSH, __0_result__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.GateResult(bool)
        JUMP, 0x00000738
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __intnl_SystemInt32_6
        PUSH, __const_SystemInt32_1
        PUSH, __intnl_SystemInt32_6
        EXTERN, "SystemInt32.__op_Addition__SystemInt32_SystemInt32__SystemInt32"
        JUMP, 0x000005EC
        PUSH, __gintnl_SystemUInt32_7
        PUSH, __const_SystemBoolean_0
        PUSH, __0_result__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.GateResult(bool)
        JUMP, 0x00000738
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.GateResult(bool)
# 
        PUSH, __const_SystemBoolean_1
        PUSH, isSendingSyncedValue
        COPY
        PUSH, __0_result__param
        JUMP_IF_FALSE, 0x000007c4
        PUSH, startEnabled
        JUMP_IF_FALSE, 0x00000798
        PUSH, __gintnl_SystemUInt32_8
        PUSH, __const_SystemBoolean_0
        PUSH, __0_value__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.set
        JUMP, 0x00000074
        JUMP, 0x000007BC
        PUSH, __gintnl_SystemUInt32_9
        PUSH, __const_SystemBoolean_1
        PUSH, __0_value__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.set
        JUMP, 0x00000074
        JUMP, 0x00000824
        PUSH, startEnabled
        JUMP_IF_FALSE, 0x00000800
        PUSH, __gintnl_SystemUInt32_10
        PUSH, __const_SystemBoolean_1
        PUSH, __0_value__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.set
        JUMP, 0x00000074
        JUMP, 0x00000824
        PUSH, __gintnl_SystemUInt32_11
        PUSH, __const_SystemBoolean_0
        PUSH, __0_value__param
        COPY
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.set
        JUMP, 0x00000074
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
        PUSH, __const_SystemUInt32_0
# 
# DecentM.PortalPuzzlemaker.PuzzleElementConnection.HandleOutputStateChange()
# 
        PUSH, __const_SystemBoolean_0
        PUSH, isSendingSyncedValue
        COPY
        PUSH, __gintnl_SystemUInt32_12
# Calling DecentM.PortalPuzzlemaker.PuzzleElementConnection.outputState.get
        JUMP, 0x00000008
        PUSH, __0_get_outputState__ret
        JUMP_IF_FALSE, 0x000008a8
        PUSH, output
# Cow dirty
        PUSH, output
        PUSH, __intnl_VRCUdonUdonBehaviour_0
        COPY
        PUSH, __const_SystemString_7
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        JUMP, 0x000008D4
        PUSH, output
# Cow dirty
        PUSH, output
        PUSH, __intnl_VRCUdonUdonBehaviour_1
        COPY
        PUSH, __const_SystemString_8
        EXTERN, "VRCUdonCommonInterfacesIUdonEventReceiver.__SendCustomEvent__SystemString__SystemVoid"
        PUSH, __intnl_returnJump_SystemUInt32_0
        COPY
        JUMP_INDIRECT, __intnl_returnJump_SystemUInt32_0
.code_end

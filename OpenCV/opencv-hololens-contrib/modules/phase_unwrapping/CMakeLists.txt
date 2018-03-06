set(the_description "Phase Unwrapping API")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(phase_unwrapping opencv_core opencv_imgproc WRAP python java)

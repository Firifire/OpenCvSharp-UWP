set(the_description "Structured Light API")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(structured_light opencv_core opencv_imgproc opencv_calib3d opencv_phase_unwrapping OPTIONAL opencv_viz WRAP python java)

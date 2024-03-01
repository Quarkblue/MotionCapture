# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mediapipe/calculators/video/motion_analysis_calculator.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from mediapipe.framework import calculator_pb2 as mediapipe_dot_framework_dot_calculator__pb2
try:
  mediapipe_dot_framework_dot_calculator__options__pb2 = mediapipe_dot_framework_dot_calculator__pb2.mediapipe_dot_framework_dot_calculator__options__pb2
except AttributeError:
  mediapipe_dot_framework_dot_calculator__options__pb2 = mediapipe_dot_framework_dot_calculator__pb2.mediapipe.framework.calculator_options_pb2
from mediapipe.util.tracking import motion_analysis_pb2 as mediapipe_dot_util_dot_tracking_dot_motion__analysis__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='mediapipe/calculators/video/motion_analysis_calculator.proto',
  package='mediapipe',
  syntax='proto2',
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n<mediapipe/calculators/video/motion_analysis_calculator.proto\x12\tmediapipe\x1a$mediapipe/framework/calculator.proto\x1a-mediapipe/util/tracking/motion_analysis.proto\"\xe5\x05\n\x1fMotionAnalysisCalculatorOptions\x12:\n\x10\x61nalysis_options\x18\x01 \x01(\x0b\x32 .mediapipe.MotionAnalysisOptions\x12l\n\x12selection_analysis\x18\x04 \x01(\x0e\x32<.mediapipe.MotionAnalysisCalculatorOptions.SelectionAnalysis:\x12\x41NALYSIS_WITH_SEED\x12&\n\x17hybrid_selection_camera\x18\x05 \x01(\x08:\x05\x66\x61lse\x12\x66\n\rmeta_analysis\x18\x08 \x01(\x0e\x32\x37.mediapipe.MotionAnalysisCalculatorOptions.MetaAnalysis:\x16META_ANALYSIS_USE_META\x12 \n\x15meta_models_per_frame\x18\x06 \x01(\x05:\x01\x31\x12)\n\x19meta_outlier_domain_ratio\x18\t \x01(\x02:\x06\x30.0015\x12\x1a\n\x0b\x62ypass_mode\x18\x07 \x01(\x08:\x05\x66\x61lse\"~\n\x11SelectionAnalysis\x12\x16\n\x12\x41NALYSIS_RECOMPUTE\x10\x01\x12\x1d\n\x19NO_ANALYSIS_USE_SELECTION\x10\x02\x12\x1a\n\x16\x41NALYSIS_FROM_FEATURES\x10\x03\x12\x16\n\x12\x41NALYSIS_WITH_SEED\x10\x04\"D\n\x0cMetaAnalysis\x12\x1a\n\x16META_ANALYSIS_USE_META\x10\x01\x12\x18\n\x14META_ANALYSIS_HYBRID\x10\x02\x32Y\n\x03\x65xt\x12\x1c.mediapipe.CalculatorOptions\x18\x8f\x8e\x8a\x81\x01 \x01(\x0b\x32*.mediapipe.MotionAnalysisCalculatorOptions\"\x81\x01\n\x0eHomographyData\x12\"\n\x16motion_homography_data\x18\x01 \x03(\x02\x42\x02\x10\x01\x12 \n\x14histogram_count_data\x18\x02 \x03(\rB\x02\x10\x01\x12\x13\n\x0b\x66rame_width\x18\x03 \x01(\x05\x12\x14\n\x0c\x66rame_height\x18\x04 \x01(\x05'
  ,
  dependencies=[mediapipe_dot_framework_dot_calculator__pb2.DESCRIPTOR,mediapipe_dot_util_dot_tracking_dot_motion__analysis__pb2.DESCRIPTOR,])



_MOTIONANALYSISCALCULATOROPTIONS_SELECTIONANALYSIS = _descriptor.EnumDescriptor(
  name='SelectionAnalysis',
  full_name='mediapipe.MotionAnalysisCalculatorOptions.SelectionAnalysis',
  filename=None,
  file=DESCRIPTOR,
  create_key=_descriptor._internal_create_key,
  values=[
    _descriptor.EnumValueDescriptor(
      name='ANALYSIS_RECOMPUTE', index=0, number=1,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='NO_ANALYSIS_USE_SELECTION', index=1, number=2,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ANALYSIS_FROM_FEATURES', index=2, number=3,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ANALYSIS_WITH_SEED', index=3, number=4,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
  ],
  containing_type=None,
  serialized_options=None,
  serialized_start=615,
  serialized_end=741,
)
_sym_db.RegisterEnumDescriptor(_MOTIONANALYSISCALCULATOROPTIONS_SELECTIONANALYSIS)

_MOTIONANALYSISCALCULATOROPTIONS_METAANALYSIS = _descriptor.EnumDescriptor(
  name='MetaAnalysis',
  full_name='mediapipe.MotionAnalysisCalculatorOptions.MetaAnalysis',
  filename=None,
  file=DESCRIPTOR,
  create_key=_descriptor._internal_create_key,
  values=[
    _descriptor.EnumValueDescriptor(
      name='META_ANALYSIS_USE_META', index=0, number=1,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='META_ANALYSIS_HYBRID', index=1, number=2,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
  ],
  containing_type=None,
  serialized_options=None,
  serialized_start=743,
  serialized_end=811,
)
_sym_db.RegisterEnumDescriptor(_MOTIONANALYSISCALCULATOROPTIONS_METAANALYSIS)


_MOTIONANALYSISCALCULATOROPTIONS = _descriptor.Descriptor(
  name='MotionAnalysisCalculatorOptions',
  full_name='mediapipe.MotionAnalysisCalculatorOptions',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='analysis_options', full_name='mediapipe.MotionAnalysisCalculatorOptions.analysis_options', index=0,
      number=1, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='selection_analysis', full_name='mediapipe.MotionAnalysisCalculatorOptions.selection_analysis', index=1,
      number=4, type=14, cpp_type=8, label=1,
      has_default_value=True, default_value=4,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='hybrid_selection_camera', full_name='mediapipe.MotionAnalysisCalculatorOptions.hybrid_selection_camera', index=2,
      number=5, type=8, cpp_type=7, label=1,
      has_default_value=True, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='meta_analysis', full_name='mediapipe.MotionAnalysisCalculatorOptions.meta_analysis', index=3,
      number=8, type=14, cpp_type=8, label=1,
      has_default_value=True, default_value=1,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='meta_models_per_frame', full_name='mediapipe.MotionAnalysisCalculatorOptions.meta_models_per_frame', index=4,
      number=6, type=5, cpp_type=1, label=1,
      has_default_value=True, default_value=1,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='meta_outlier_domain_ratio', full_name='mediapipe.MotionAnalysisCalculatorOptions.meta_outlier_domain_ratio', index=5,
      number=9, type=2, cpp_type=6, label=1,
      has_default_value=True, default_value=float(0.0015),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='bypass_mode', full_name='mediapipe.MotionAnalysisCalculatorOptions.bypass_mode', index=6,
      number=7, type=8, cpp_type=7, label=1,
      has_default_value=True, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
    _descriptor.FieldDescriptor(
      name='ext', full_name='mediapipe.MotionAnalysisCalculatorOptions.ext', index=0,
      number=270698255, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=True, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  nested_types=[],
  enum_types=[
    _MOTIONANALYSISCALCULATOROPTIONS_SELECTIONANALYSIS,
    _MOTIONANALYSISCALCULATOROPTIONS_METAANALYSIS,
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=161,
  serialized_end=902,
)


_HOMOGRAPHYDATA = _descriptor.Descriptor(
  name='HomographyData',
  full_name='mediapipe.HomographyData',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='motion_homography_data', full_name='mediapipe.HomographyData.motion_homography_data', index=0,
      number=1, type=2, cpp_type=6, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=b'\020\001', file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='histogram_count_data', full_name='mediapipe.HomographyData.histogram_count_data', index=1,
      number=2, type=13, cpp_type=3, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=b'\020\001', file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='frame_width', full_name='mediapipe.HomographyData.frame_width', index=2,
      number=3, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='frame_height', full_name='mediapipe.HomographyData.frame_height', index=3,
      number=4, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=905,
  serialized_end=1034,
)

_MOTIONANALYSISCALCULATOROPTIONS.fields_by_name['analysis_options'].message_type = mediapipe_dot_util_dot_tracking_dot_motion__analysis__pb2._MOTIONANALYSISOPTIONS
_MOTIONANALYSISCALCULATOROPTIONS.fields_by_name['selection_analysis'].enum_type = _MOTIONANALYSISCALCULATOROPTIONS_SELECTIONANALYSIS
_MOTIONANALYSISCALCULATOROPTIONS.fields_by_name['meta_analysis'].enum_type = _MOTIONANALYSISCALCULATOROPTIONS_METAANALYSIS
_MOTIONANALYSISCALCULATOROPTIONS_SELECTIONANALYSIS.containing_type = _MOTIONANALYSISCALCULATOROPTIONS
_MOTIONANALYSISCALCULATOROPTIONS_METAANALYSIS.containing_type = _MOTIONANALYSISCALCULATOROPTIONS
DESCRIPTOR.message_types_by_name['MotionAnalysisCalculatorOptions'] = _MOTIONANALYSISCALCULATOROPTIONS
DESCRIPTOR.message_types_by_name['HomographyData'] = _HOMOGRAPHYDATA
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

MotionAnalysisCalculatorOptions = _reflection.GeneratedProtocolMessageType('MotionAnalysisCalculatorOptions', (_message.Message,), {
  'DESCRIPTOR' : _MOTIONANALYSISCALCULATOROPTIONS,
  '__module__' : 'mediapipe.calculators.video.motion_analysis_calculator_pb2'
  # @@protoc_insertion_point(class_scope:mediapipe.MotionAnalysisCalculatorOptions)
  })
_sym_db.RegisterMessage(MotionAnalysisCalculatorOptions)

HomographyData = _reflection.GeneratedProtocolMessageType('HomographyData', (_message.Message,), {
  'DESCRIPTOR' : _HOMOGRAPHYDATA,
  '__module__' : 'mediapipe.calculators.video.motion_analysis_calculator_pb2'
  # @@protoc_insertion_point(class_scope:mediapipe.HomographyData)
  })
_sym_db.RegisterMessage(HomographyData)

_MOTIONANALYSISCALCULATOROPTIONS.extensions_by_name['ext'].message_type = _MOTIONANALYSISCALCULATOROPTIONS
mediapipe_dot_framework_dot_calculator__options__pb2.CalculatorOptions.RegisterExtension(_MOTIONANALYSISCALCULATOROPTIONS.extensions_by_name['ext'])

_HOMOGRAPHYDATA.fields_by_name['motion_homography_data']._options = None
_HOMOGRAPHYDATA.fields_by_name['histogram_count_data']._options = None
# @@protoc_insertion_point(module_scope)

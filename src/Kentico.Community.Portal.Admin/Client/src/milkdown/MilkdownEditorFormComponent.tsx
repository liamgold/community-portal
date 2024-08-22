import { FormComponentProps } from '@kentico/xperience-admin-base';
import { FormItemWrapper } from '@kentico/xperience-admin-components';
import { MilkdownProvider } from '@milkdown/react';
import * as React from 'react';
import { MilkdownEditor } from './MilkdownEditor';

export const MilkdownEditorFormComponent: React.FC<FormComponentProps> = (
  props,
) => {
  const handleOnChange = (value: string) => {
    if (props.onChange) {
      props.onChange(value);
    }
  };

  const defaultValue: string = props.value as string;

  return (
    <FormItemWrapper
      label={props.label}
      explanationText={props.explanationText}
      invalid={props.invalid}
      validationMessage={props.validationMessage}
      markAsRequired={props.required}
      labelIcon={props.tooltip ? 'xp-i-circle' : undefined}
      labelIconTooltip={props.tooltip}
    >
      <div>
        <MilkdownProvider>
          <MilkdownEditor
            defaultValue={defaultValue}
            UpdateValue={handleOnChange}
          />
          <div>
            <h3>Markdown Output:</h3>
            <pre>{props.value}</pre>
          </div>
        </MilkdownProvider>
      </div>
    </FormItemWrapper>
  );
};
